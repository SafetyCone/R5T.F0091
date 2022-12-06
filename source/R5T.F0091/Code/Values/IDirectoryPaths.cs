using System;

using R5T.T0131;


namespace R5T.F0091
{
	[ValuesMarker]
	public partial interface IDirectoryPaths : IValuesMarker
	{
        public string FilesDirectoryPath => IDirectoryPaths.zFilesDirectoryPath.Value;
        private static readonly Lazy<string> zFilesDirectoryPath = new Lazy<string>(
            FilesDirectoryOperator.Instance.GetFilesDirectoryPath);
    }
}