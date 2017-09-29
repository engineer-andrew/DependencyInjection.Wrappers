using System;
using System.IO;

namespace DependencyInjection.Wrappers.SystemIOFileInfo
{
    public class FileInfoOperationWrapper : IWrapFileInfoOperations
    {
        public FileAttributes Attributes {
            get {
                return FileInfo.Attributes;
            }
            set {
                FileInfo.Attributes = value;
            }
        }

        public DateTime CreationTime
        {
            get
            {
                return FileInfo.CreationTime;
            }
            set
            {
                FileInfo.CreationTime = value;
            }
        }

        public DateTime CreationTimeUtc
        {
            get
            {
                return FileInfo.CreationTimeUtc;
            }
            set
            {
                FileInfo.CreationTimeUtc = value;
            }
        }

        public DirectoryInfo Directory
        {
            get
            {
                return FileInfo.Directory;
            }
        }

        public string DirectoryName
        {
            get
            {
                return FileInfo.DirectoryName;
            }
        }

        public bool Exists
        {
            get
            {
                return FileInfo.Exists;
            }
        }

        public string Extension
        {
            get
            {
                return FileInfo.Extension;
            }
        }

        public FileInfo FileInfo { get; private set; }

        public string FullName
        {
            get
            {
                return FileInfo.FullName;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return FileInfo.IsReadOnly;
            }
            set
            {
                FileInfo.IsReadOnly = value;
            }
        }

        public DateTime LastAccessTime
        {
            get
            {
                return FileInfo.LastAccessTime;
            }
            set
            {
                FileInfo.LastAccessTime = value;
            }
        }

        public DateTime LastAccessTimeUtc
        {
            get
            {
                return FileInfo.LastAccessTimeUtc;
            }
            set
            {
                FileInfo.LastAccessTimeUtc = value;
            }
        }

        public DateTime LastWriteTime
        {
            get
            {
                return FileInfo.LastWriteTime;
            }
            set
            {
                FileInfo.LastWriteTime = value;
            }
        }
        
        public DateTime LastWriteTimeUtc
        {
            get
            {
                return FileInfo.LastWriteTimeUtc;
            }
            set
            {
                FileInfo.LastWriteTimeUtc = value;
            }
        }

        public long Length
        {
            get
            {
                return FileInfo.Length;
            }
        }

        public string Name
        {
            get
            {
                return FileInfo.Name;
            }
        }

        public StreamWriter AppendText()
        {
            throw new NotImplementedException();
        }

        public FileInfo CopyTo(string destFileName)
        {
            return FileInfo.CopyTo(destFileName);
        }

        public FileInfo CopyTo(string destFileName, bool overwrite)
        {
            return FileInfo.CopyTo(destFileName, overwrite);
        }

        public void Create(string fileName)
        {
            FileInfo = new FileInfo(fileName);
        }

        public FileStream Create()
        {
            return FileInfo.Create();
        }

        public StreamWriter CreateText()
        {
            return FileInfo.CreateText();
        }

        public void Delete()
        {
            FileInfo.Delete();
        }

        public override bool Equals(object obj)
        {
            return FileInfo.Equals(obj);
        }

        public override int GetHashCode()
        {
            return FileInfo.GetHashCode();
        }
        
        public void MoveTo(string destFileName)
        {
            FileInfo.MoveTo(destFileName);
        }

        public FileStream Open(FileMode mode)
        {
            return FileInfo.Open(mode);
        }

        public FileStream Open(FileMode mode, FileAccess access)
        {
            return FileInfo.Open(mode, access);
        }

        public FileStream Open(FileMode mode, FileAccess access, FileShare share)
        {
            return FileInfo.Open(mode, access, share);
        }

        public FileStream OpenRead()
        {
            return FileInfo.OpenRead();
        }

        public StreamReader OpenText()
        {
            return FileInfo.OpenText();
        }

        public FileStream OpenWrite()
        {
            return FileInfo.OpenWrite();
        }

        public void Refresh()
        {
            return FileInfo.Refresh();
        }

        public override string ToString()
        {
            return FileInfo.ToString();
        }
    }
}