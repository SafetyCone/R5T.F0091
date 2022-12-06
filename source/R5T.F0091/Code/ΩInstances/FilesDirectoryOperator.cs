using System;


namespace R5T.F0091
{
	public class FilesDirectoryOperator : IFilesDirectoryOperator
	{
		#region Infrastructure

	    public static IFilesDirectoryOperator Instance { get; } = new FilesDirectoryOperator();

	    private FilesDirectoryOperator()
	    {
        }

	    #endregion
	}
}