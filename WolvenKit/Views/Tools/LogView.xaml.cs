using System;
using System.Reactive.Linq;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Media;
using System.Windows.Threading;
using DynamicData;
using ReactiveUI;
using Serilog.Events;
using Splat;
using WolvenKit.App;
using WolvenKit.App.Helpers;
using WolvenKit.App.ViewModels.Tools;
using WolvenKit.Common;

namespace WolvenKit.Views.Tools
{
    /// <summary>
    /// Interaction logic for LogView.xaml
    /// </summary>
    public partial class LogView : ReactiveUserControl<LogViewModel>
    {
        public LogView()
        {
            InitializeComponent();

            ViewModel = Locator.Current.GetService<LogViewModel>();
            DataContext = ViewModel;

            //var logger = Locator.Current.GetService<ILoggerService>();
            //logger.Connect()
            //    .ObserveOn(RxApp.MainThreadScheduler)
            //    .Bind(out var _logEntries)
            //    .Subscribe(OnNext);

            var _sink = Locator.Current.GetService<MySink>();
            var myOperation = _sink.Connect()
            //.Transform(x => x.RenderMessage())
            .ObserveOn(RxApp.MainThreadScheduler)
            .Bind(out var _logEntries)
            .DisposeMany()
            .Subscribe(OnNext);

            var consolas = new FontFamily("Consolas");
            if (consolas != null)
            {
                LogRichTextBox.FontFamily = consolas;
                LogRichTextBox.FontSize = 10;
            }
        }

        private void OnNext(IChangeSet<LogEvent> obj)
        {
            foreach (var change in obj)
            {
                switch (change.Reason)
                {
                    case ListChangeReason.Add:
                        var item = change.Item.Current;
                        AddLog(item);
                        break;
                    case ListChangeReason.AddRange:
                        foreach (var logEntry in change.Range)
                        {
                            AddLog(logEntry);
                        }
                        break;
                    case ListChangeReason.Replace:
                    case ListChangeReason.Remove:
                    case ListChangeReason.RemoveRange:
                    case ListChangeReason.Refresh:
                    case ListChangeReason.Moved:
                    case ListChangeReason.Clear:
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
        }

        private void AddLog(LogEvent item)
        {
            var level = ToLogtype(item.Level);

#if !DEBUG
            // don't log Debug on release build
            if (level == Logtype.Debug)
            {
                return;
            }
#endif

            if (item.Properties.TryGetValue(Core.Constants.IsSuccess, out var val) && val is ScalarValue { Value: true })
            {
                // ... 
                level = Logtype.Success;
            }

            var paragraph = new Paragraph()
            {
                LineHeight = 1
            };
            var run = new Run($"[{DateTime.Now}] [{level,-9}] {item.RenderMessage()}")
            {
                Foreground = GetBrushForLevel(level),
                FontSize = 12,
            };
            paragraph.Inlines.Add(run);
            LogRichTextBox.Document.Blocks.Add(paragraph);

            DispatcherHelper.RunOnMainThread(() => LogRichTextBox.ScrollToEnd(), DispatcherPriority.Background);
        }

        private static Logtype ToLogtype(LogEventLevel level)
        {
            return level switch
            {
                LogEventLevel.Verbose => Logtype.Debug,
                LogEventLevel.Debug => Logtype.Debug,
                LogEventLevel.Information => Logtype.Important,
                LogEventLevel.Warning => Logtype.Warning,
                LogEventLevel.Error => Logtype.Error,
                LogEventLevel.Fatal => Logtype.Error,
                _ => Logtype.Normal,
            };
        }

        private static Brush GetBrushForLevel(Logtype level) => level switch
        {
            Logtype.Normal or Logtype.Important => Brushes.LightGray,
            Logtype.Error => (Brush)Application.Current.FindResource("WolvenKitRed"),
            Logtype.Warning => (Brush)Application.Current.FindResource("WolvenKitYellow"),
            Logtype.Debug => (Brush)Application.Current.FindResource("WolvenKitPurple"),
            Logtype.Success => Brushes.Green,

            _ => throw new ArgumentOutOfRangeException(nameof(level), level, null),
        };

        private void Button_Click(object sender, RoutedEventArgs e) => LogRichTextBox.Document.Blocks.Clear();
    }
}
