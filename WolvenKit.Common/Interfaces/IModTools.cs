using System.IO;
using System.Threading.Tasks;
using WolvenKit.Common.DDS;
using WolvenKit.Common.Model;
using WolvenKit.Common.Model.Arguments;
using WolvenKit.RED4.Archive;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Types;

namespace WolvenKit.Common.Interfaces
{
    public interface IModTools
    {
        public Archive Pack(DirectoryInfo infolder, DirectoryInfo outpath, string? modname = null);

        public bool ConvertXbmToDdsStream(Stream redInFile, Stream outstream, out DXGI_FORMAT texformat, out DXGI_FORMAT decompressedFormat);

        //public bool ConvertCR2WToDdsStream(CR2WFile cr2w, Stream outstream, out DXGI_FORMAT texformat);


        public Task<bool> Import(RedRelativePath rawRelative, GlobalImportArgs args, DirectoryInfo? outDir = null);
        public Task<bool> ImportFolder(DirectoryInfo inDir, GlobalImportArgs args, DirectoryInfo? outDir = null);


        public bool Export(FileInfo cr2wfile, GlobalExportArgs args, DirectoryInfo basedir,
            DirectoryInfo? rawoutdir = null, ECookedFileFormat[]? forcebuffers = null);

        bool RebuildBuffer(RedRelativePath rawRelativePath, DirectoryInfo outDir);

        void ExtractAll(ICyberGameArchive ar, DirectoryInfo outDir, string pattern = "", string regex = "", bool decompressBuffers = false);
        Task ExtractAllAsync(ICyberGameArchive ar, DirectoryInfo outDir, string pattern = "", string regex = "", bool decompressBuffers = false);

        public bool UncookSingle(
            ICyberGameArchive archive,
            ulong hash,
            DirectoryInfo outDir,
            GlobalExportArgs args,
            DirectoryInfo? rawOutDir = null,
            ECookedFileFormat[]? forcebuffers = null,
            bool serialize = false);

        public Task<bool> UncookSingleAsync(
            ICyberGameArchive archive,
            ulong hash,
            DirectoryInfo outDir,
            GlobalExportArgs args,
            DirectoryInfo? rawOutDir = null,
            ECookedFileFormat[]? forcebuffers = null,
            bool serialize = false);

        void UncookAll(
            ICyberGameArchive ar,
            DirectoryInfo outDir,
            GlobalExportArgs args,
            bool unbundle = false,
            string? pattern = null,
            string? regex = null,
            DirectoryInfo? rawOutDir = null,
            ECookedFileFormat[]? forcebuffers = null,
            bool serialize = false);


        public Task<string> ConvertToJsonAsync(string infile, bool skipHeader = false);
        public Task ConvertToJsonAsync(Stream stream, string infile, bool skipHeader = false);
        public Task<bool> ConvertToJsonAndWriteAsync(string infile, DirectoryInfo outputDirInfo);

        public Task<bool> ConvertFromJsonAndWriteAsync(FileInfo fileInfo, DirectoryInfo outputDirInfo);

        public bool ExportEntity(CR2WFile entFile, CName appearance, FileInfo outfile);
        
    }

}
