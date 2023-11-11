namespace chapter9_features;

public class FileOrderer
{
    public void ReadFilesWithLinq()
    {
        var directory = new DirectoryInfo("../../../files-for-exercise");

        directory.GetFiles()
            .OrderByDescending(fileInfo => fileInfo.Length)
            .Take(5)
            .ToList()
            .ForEach(fileInfo => Console.WriteLine($"File: {fileInfo.Name}. Length: {fileInfo.Length}"));
    }
    
    public void ReadFiles()
    {
        var directory = new DirectoryInfo("../../../files-for-exercise");
        var files = directory.GetFiles();

        Array.Sort(files, _compareFiles);
        
        for (var i = files.Length - 1; i > files.Length - 6; i--)
            Console.WriteLine($"File: {files[i].Name}. Length: {files[i].Length}");
    }

    private int _compareFiles(FileInfo file1, FileInfo file2)
    {
        return file1.Length > file2.Length ? 1 : -1;
    }
}