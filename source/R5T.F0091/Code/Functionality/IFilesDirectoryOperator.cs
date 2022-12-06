using System;
using System.Collections.Generic;
using System.Linq;

using R5T.T0132;


namespace R5T.F0091
{
	[FunctionalityMarker]
	public partial interface IFilesDirectoryOperator : IFunctionalityMarker
	{
		public string GetFilesDirectoryPath(string executableDirectoryPath)
		{
			var filesDirectoryPath = Instances.PathOperator.GetDirectoryPath(
				executableDirectoryPath,
				DirectoryNames.Instance.Files);

			return filesDirectoryPath;
		}

        public string GetFilesDirectoryPath()
        {
			var executableDirectoryPath = Instances.ExecutablePathOperator.GetExecutableDirectoryPath();

			var filesDirectoryPath = this.GetFilesDirectoryPath(executableDirectoryPath);
            return filesDirectoryPath;
        }

		public string GetFilesDirectoryDirectoryPath(IEnumerable<string> directoryPathParts)
		{
			var directoryPath = Instances.PathOperator.GetDirectoryPath(
				DirectoryPaths.Instance.FilesDirectoryPath,
				directoryPathParts);

			return directoryPath;
		}

        public string GetFilesDirectoryDirectoryPath(params string[] directoryPathParts)
		{
			var directoryPath = this.GetFilesDirectoryDirectoryPath(
				directoryPathParts.AsEnumerable());

			return directoryPath;
		}

        public string GetFilesDirectoryFilePath(IEnumerable<string> filePathParts)
		{
			var filePath = Instances.PathOperator.GetFilePath(
				DirectoryPaths.Instance.FilesDirectoryPath,
				filePathParts);

			return filePath;
		}

        public string GetFilesDirectoryFilePath(params string[] filePathParts)
		{
			var filePath = this.GetFilesDirectoryFilePath(
				filePathParts.AsEnumerable());

			return filePath;
		}
    }
}