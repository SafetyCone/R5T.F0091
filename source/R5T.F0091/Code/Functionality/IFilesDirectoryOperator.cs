using System;
using System.Collections.Generic;
using System.Linq;

using R5T.T0132;


namespace R5T.F0091
{
	/// <summary>
	/// 
	/// </summary>
	/// <remarks>
	/// New functionality in R5T.L0071.
	/// </remarks>
	[FunctionalityMarker]
	public partial interface IFilesDirectoryOperator : IFunctionalityMarker
	{
		// See R5T.L0071
		public string GetFilesDirectoryPath(string executableDirectoryPath)
		{
			var filesDirectoryPath = Instances.PathOperator.Get_DirectoryPath(
				executableDirectoryPath,
				DirectoryNames.Instance.Files);

			return filesDirectoryPath;
		}

        public string GetFilesDirectoryPath()
        {
			var executableDirectoryPath = Instances.ExecutablePathOperator.Get_ExecutableDirectoryPath();

			var filesDirectoryPath = this.GetFilesDirectoryPath(executableDirectoryPath);
            return filesDirectoryPath;
        }

		public string GetFilesDirectoryDirectoryPath(IEnumerable<string> directoryPathParts)
		{
			var directoryPath = Instances.PathOperator.Get_DirectoryPath(
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
			var filePath = Instances.PathOperator.Get_FilePath(
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

		public string GetFilesDirectoryFilePath_UsingProjectNameDirectory(
			string projectNameDirectoryName,
			string fileName)
		{
			var output = this.GetFilesDirectoryFilePath(
				projectNameDirectoryName,
				fileName);

			return output;
		}
    }
}