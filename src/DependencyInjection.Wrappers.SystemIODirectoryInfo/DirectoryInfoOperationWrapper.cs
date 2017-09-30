using System;
using System.Collections.Generic;
using System.IO;

namespace DependencyInjection.Wrappers.SystemIODirectoryInfo
{
    public class DirectoryInfoOperationWrapper : IWrapDirectoryInfoOperations
    {
        private DirectoryInfo _directoryInfo;

        public FileAttributes Attributes
        {
            get { return _directoryInfo.Attributes; }
            set { _directoryInfo.Attributes = value; }
        }

        public DateTime CreationTime
        {
            get { return _directoryInfo.CreationTime; }
            set { _directoryInfo.CreationTime = value; }
        }

        public DateTime CreationTimeUtc
        {
            get { return _directoryInfo.CreationTimeUtc; }
            set { _directoryInfo.CreationTimeUtc = value; }
        }

        public bool Exists { get { return _directoryInfo.Exists; } }

        public string Extension { get { return _directoryInfo.Extension; } }

        public string FullName { get { return _directoryInfo.FullName; } }

        public DateTime LastAccessTime
        {
            get { return _directoryInfo.LastAccessTime; }
            set { _directoryInfo.LastAccessTime = value; }
        }

        public DateTime LastAccessTimeUtc
        {
            get { return _directoryInfo.LastAccessTimeUtc; }
            set { _directoryInfo.LastAccessTimeUtc = value; }
        }

        public DateTime LastWriteTime
        {
            get { return _directoryInfo.LastWriteTime; }
            set { _directoryInfo.LastWriteTime = value; }
        }

        public DateTime LastWriteTimeUtc
        {
            get { return _directoryInfo.LastWriteTimeUtc; }
            set { _directoryInfo.LastWriteTimeUtc = value; }
        }

        public string Name
        {
            get { return _directoryInfo.Name; }
        }

        public DirectoryInfo Parent
        {
            get { return _directoryInfo.Parent; }
        }

        public DirectoryInfo Root
        {
            get { return _directoryInfo.Root; }
        }

        public void Create()
        {
            _directoryInfo.Create();
        }

        public void Create(string path)
        {
            _directoryInfo = new DirectoryInfo(path);
        }

        public DirectoryInfo CreateSubDirectory(string path)
        {
            return _directoryInfo.CreateSubdirectory(path);
        }

        public void Delete()
        {
            _directoryInfo.Delete();
        }

        public void Delete(bool recursive)
        {
            _directoryInfo.Delete(recursive);
        }

        public IEnumerable<DirectoryInfo> EnumerateDirectories()
        {
            return _directoryInfo.EnumerateDirectories();
        }

        public IEnumerable<DirectoryInfo> EnumerateDirectories(string searchPattern)
        {
            return _directoryInfo.EnumerateDirectories(searchPattern);
        }

        public IEnumerable<DirectoryInfo> EnumerateDirectories(string searchPattern, SearchOption searchOption)
        {
            return _directoryInfo.EnumerateDirectories(searchPattern, searchOption);
        }

        public IEnumerable<FileInfo> EnumerateFiles()
        {
            return _directoryInfo.EnumerateFiles();
        }

        public IEnumerable<FileInfo> EnumerateFiles(string searchPattern)
        {
            return _directoryInfo.EnumerateFiles(searchPattern);
        }

        public IEnumerable<FileInfo> EnumerateFiles(string searchPattern, SearchOption searchOption)
        {
            return _directoryInfo.EnumerateFiles(searchPattern, searchOption);
        }

        public IEnumerable<FileSystemInfo> EnumerateFileSystemInfos()
        {
            return _directoryInfo.EnumerateFileSystemInfos();
        }

        public IEnumerable<FileSystemInfo> EnumerateFileSystemInfos(string searchPattern)
        {
            return _directoryInfo.EnumerateFileSystemInfos(searchPattern);
        }

        public IEnumerable<FileSystemInfo> EnumerateFileSystemInfos(string searchPattern, SearchOption searchOption)
        {
            return _directoryInfo.EnumerateFileSystemInfos(searchPattern, searchOption);
        }

        public override bool Equals(object obj)
        {
            return _directoryInfo.Equals(obj);
        }

        public DirectoryInfo[] GetDirectories()
        {
            return _directoryInfo.GetDirectories();
        }

        public DirectoryInfo[] GetDirectories(string searchPattern)
        {
            return _directoryInfo.GetDirectories(searchPattern);
        }

        public DirectoryInfo[] GetDirectories(string searchPattern, SearchOption searchOption)
        {
            return _directoryInfo.GetDirectories(searchPattern, searchOption);
        }

        public FileInfo[] GetFiles()
        {
            return _directoryInfo.GetFiles();
        }

        public FileInfo[] GetFiles(string searchPattern)
        {
            return _directoryInfo.GetFiles(searchPattern);
        }

        public FileInfo[] GetFiles(string searchPattern, SearchOption searchOption)
        {
            return _directoryInfo.GetFiles(searchPattern, searchOption);
        }

        public FileSystemInfo[] GetFileSystemInfos()
        {
            return _directoryInfo.GetFileSystemInfos();
        }

        public FileSystemInfo[] GetFileSystemInfos(string searchPattern)
        {
            return _directoryInfo.GetFileSystemInfos(searchPattern);
        }

        public FileSystemInfo[] GetFileSystemInfos(string searchPattern, SearchOption searchOption)
        {
            return _directoryInfo.GetFileSystemInfos(searchPattern, searchOption);
        }

        public override int GetHashCode()
        {
            return _directoryInfo.GetHashCode();
        }

        public void MoveTo(string destDirName)
        {
            _directoryInfo.MoveTo(destDirName);
        }

        public void Refresh()
        {
            _directoryInfo.Refresh();
        }

        public override string ToString()
        {
            return _directoryInfo.ToString();
        }
    }
}
