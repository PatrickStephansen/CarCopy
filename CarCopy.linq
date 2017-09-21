<Query Kind="Program" />

void Main(string [] args)
{
	var copiedFromDirectory = Directory.GetCurrentDirectory();
	var sourceDirectories = args.Select(a => new DirectoryInfo(a));
	var destination = @"D:\";
	
	var copyJobs = 
		sourceDirectories
			.SelectMany(GetFilesInDirectory)
			.Select(f => 
				new FileCopyInfo {
					SourceFilePath = f.FullName,
					CopiedFromDirectory = copiedFromDirectory
				})
			.OrderBy(c => c.FileName);
	
	foreach(var job in copyJobs)
	{
		job.CopyTo(destination);
	}
}

// Define other methods and classes here
private IEnumerable<FileInfo> GetFilesInDirectory(DirectoryInfo directory)
{
	var subDirectories = directory.GetDirectories();
	return subDirectories
		.SelectMany(GetFilesInDirectory)
		.Concat(directory.GetFiles());
}

private class FileCopyInfo
{
	public string SourceFilePath { get; set; }
	public string CopiedFromDirectory { get; set; }
	public string FileName { get { return Path.GetFileName(SourceFilePath); } }
	
	public void CopyTo(string destinationDirectory)
	{
		var relativeFilePath = SourceFilePath.Substring(CopiedFromDirectory.Length + 1); // the leading slash is treated as root otherwise
		var desinationPath = Path.Combine(destinationDirectory, relativeFilePath);
		Directory.CreateDirectory(Path.GetDirectoryName(desinationPath));
		SourceFilePath.Dump("\r\nCopying");
		desinationPath.Dump("\r\nTo");
		File.Copy(SourceFilePath, desinationPath, true);
	}
}