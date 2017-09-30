using System;
using System.Collections.Generic;
using System.IO;

namespace DependencyInjection.Wrappers.SystemIODirectoryInfo
{
    interface IWrapDirectoryInfoOperations
    {
        /// <summary>
        /// Gets or sets the attributes for the current file or directory.
        /// </summary>
        FileAttributes Attributes { get; set; }

        /// <summary>
        /// Gets or sets the creation time of the current file or directory.
        /// </summary>
        DateTime CreationTime { get; set; }

        /// <summary>
        /// Gets or sets the creation time, in coordinated universal time (UTC), of the current file or directory.
        /// </summary>
        DateTime CreationTimeUtc { get; set; }

        /// <summary>
        /// Gets a value indicating whether the directory exists.
        /// </summary>
        bool Exists { get; }

        /// <summary>
        /// Gets the string representing the extension part of the file.
        /// </summary>
        string Extension { get; }

        /// <summary>
        /// Gets the full path of the directory.
        /// </summary>
        string FullName { get; }

        /// <summary>
        /// Gets or sets the time the current file or directory was last accessed.
        /// </summary>
        DateTime LastAccessTime { get; set; }

        /// <summary>
        /// Gets or sets the time, in coordinated universal time (UTC), that the current file or directory was last accessed.
        /// </summary>
        DateTime LastAccessTimeUtc { get; set; }

        /// <summary>
        /// Gets or sets the time when the current file or directory was last written to.
        /// </summary>
        DateTime LastWriteTime { get; set; }

        /// <summary>
        /// Gets or sets the time, in coordinated universal time (UTC), when the current file or directory was last written to.
        /// </summary>
        DateTime LastWriteTimeUtc { get; set; }

        /// <summary>
        /// Gets the name of this <see cref="DirectoryInfo"/> instance.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Gets the parent directory of a specified subdirectory.
        /// </summary>
        DirectoryInfo Parent { get; }

        /// <summary>
        /// Gets the root portion of the directory.
        /// </summary>
        DirectoryInfo Root { get; }

        /// <summary>
        /// Creates a directory.
        /// </summary>
        void Create();

        /// <summary>
        /// Initializes a new instance of the <see cref="DirectoryInfo"/> class on the specified path.
        /// </summary>
        /// <param name="path">A string specifying the path on which to create the DirectoryInfo.</param>
        void Create(string path);

        /// <summary>
        /// Creates a directory using a DirectorySecurity object.
        /// </summary>
        /// <param name="directorySecurity">The access control to apply to the directory.</param>
        //void Create(DirectorySecurity directorySecurity);

        /// <summary>
        /// Creates an object that contains all the relevant information required to generate a proxy used to communicate with a remote object.
        /// </summary>
        /// <param name="requestedType">The <see cref="Type"/> of the object that the new <see cref="ObjRef"/> will reference.</param>
        //ObjRef CreateObjRef(Type requestedType);

        /// <summary>
        /// Creates a subdirectory or subdirectories on the specified path. The specified path can be relative to this instance of the DirectoryInfo class.
        /// </summary>
        /// <param name="path">The specified path. This cannot be a different disk volume or Universal Naming Convention (UNC) name.</param>
        DirectoryInfo CreateSubDirectory(string path);

        /// <summary>
        /// Creates a subdirectory or subdirectories on the specified path with the specified security. The specified path can be relative to this instance of the DirectoryInfo class.
        /// </summary>
        /// <param name="path">The specified path. This cannot be a different disk volume or Universal Naming Convention (UNC) name.</param>
        /// <param name="directorySecurity">The security to apply.</param>
        /// <returns></returns>
        //DirectoryInfo CreateSubDirectory(string path, DirectorySecurity directorySecurity);

        /// <summary>
        /// Deletes this DirectoryInfo if it is empty.
        /// </summary>
        void Delete();

        /// <summary>
        /// Deletes this instance of a DirectoryInfo, specifying whether to delete subdirectories and files.
        /// </summary>
        /// <param name="recursive">true to delete this directory, its subdirectories, and all files; otherwise, false.</param>
        void Delete(bool recursive);

        /// <summary>
        /// Returns an enumerable collection of directory information in the current directory.
        /// </summary>
        /// <returns>An enumerable collection of directories in the current directory.</returns>
        IEnumerable<DirectoryInfo> EnumerateDirectories();

        /// <summary>
        /// Returns an enumerable collection of directory information that matches a specified search pattern.
        /// </summary>
        /// <param name="searchPattern">The search string to match against the names of directories. This parameter can contain a combination of valid literal path and wildcard (* and ?) characters (see Remarks), but doesn't support regular expressions. The default pattern is "*", which returns all files.</param>
        /// <returns>An enumerable collection of directories that matches searchPattern.</returns>
        IEnumerable<DirectoryInfo> EnumerateDirectories(string searchPattern);

        /// <summary>
        /// Returns an enumerable collection of directory information that matches a specified search pattern and search subdirectory option.
        /// </summary>
        /// <param name="searchPattern">The search string to match against the names of directories. This parameter can contain a combination of valid literal path and wildcard (* and ?) characters (see Remarks), but doesn't support regular expressions. The default pattern is "*", which returns all files.</param>
        /// <param name="searchOption">One of the enumeration values that specifies whether the search operation should include only the current directory or all subdirectories. The default value is <see cref="TopDirectoryOnly"/>.</param>
        /// <returns>An enumerable collection of directories that matches searchPattern and searchOption.</returns>
        IEnumerable<DirectoryInfo> EnumerateDirectories(string searchPattern, SearchOption searchOption);

        /// <summary>
        /// Returns an enumerable collection of file information in the current directory.
        /// </summary>
        /// <returns>An enumerable collection of the files in the current directory.</returns>
        IEnumerable<FileInfo> EnumerateFiles();

        /// <summary>
        /// Returns an enumerable collection of file information that matches a search pattern.
        /// </summary>
        /// <param name="searchPattern">The search string to match against the names of files. This parameter can contain a combination of valid literal path and wildcard (* and ?) characters (see Remarks), but doesn't support regular expressions. The default pattern is "*", which returns all files.</param>
        /// <returns>An enumerable collection of files that matches searchPattern.</returns>
        IEnumerable<FileInfo> EnumerateFiles(string searchPattern);

        /// <summary>
        /// Returns an enumerable collection of file information that matches a specified search pattern and search subdirectory option.
        /// </summary>
        /// <param name="searchPattern">The search string to match against the names of files. This parameter can contain a combination of valid literal path and wildcard (* and ?) characters (see Remarks), but doesn't support regular expressions. The default pattern is "*", which returns all files.</param>
        /// <param name="searchOption">One of the enumeration values that specifies whether the search operation should include only the current directory or all subdirectories. The default value is <see cref="TopDirectoryOnly"/>.</param>
        /// <returns>An enumerable collection of files that matches searchPattern and searchOption.</returns>
        IEnumerable<FileInfo> EnumerateFiles(string searchPattern, SearchOption searchOption);

        /// <summary>
        /// Returns an enumerable collection of file system information in the current directory.
        /// </summary>
        /// <returns>An enumerable collection of file system information in the current directory.</returns>
        IEnumerable<FileSystemInfo> EnumerateFileSystemInfos();

        /// <summary>
        /// Returns an enumerable collection of file system information that matches a specified search pattern.
        /// </summary>
        /// <param name="searchPattern">The search string to match against the names of directories. This parameter can contain a combination of valid literal path and wildcard (* and ?) characters (see Remarks), but doesn't support regular expressions. The default pattern is "*", which returns all files.</param>
        /// <returns>An enumerable collection of file system information objects that matches searchPattern.</returns>
        IEnumerable<FileSystemInfo> EnumerateFileSystemInfos(string searchPattern);

        /// <summary>
        /// Returns an enumerable collection of file system information that matches a specified search pattern and search subdirectory option.
        /// </summary>
        /// <param name="searchPattern">The search string to match against the names of directories. This parameter can contain a combination of valid literal path and wildcard (* and ?) characters (see Remarks), but doesn't support regular expressions. The default pattern is "*", which returns all files.</param>
        /// <param name="searchOption">One of the enumeration values that specifies whether the search operation should include only the current directory or all subdirectories. The default value is TopDirectoryOnly.</param>
        /// <returns>An enumerable collection of file system information objects that matches searchPattern and searchOption.</returns>
        IEnumerable<FileSystemInfo> EnumerateFileSystemInfos(string searchPattern, SearchOption searchOption);

        /// <summary>
        /// Determines whether the specified object is equal to the current object.
        /// </summary>
        /// <param name="obj">The object to compare with the current object.</param>
        /// <returns>true if the specified object is equal to the current object; otherwise, false.</returns>
        bool Equals(object obj);

        /// <summary>
        /// Gets a DirectorySecurity object that encapsulates the access control list (ACL) entries for the directory described by the current DirectoryInfo object.
        /// </summary>
        /// <returns>A <see cref="DirectorySecurity"/> object that encapsulates the access control rules for the directory.</returns>
        //DirectorySecurity GetAccessControl();

        /// <summary>
        /// Gets a DirectorySecurity object that encapsulates the specified type of access control list (ACL) entries for the directory described by the current DirectoryInfo object.
        /// </summary>
        /// <param name="includeSections">One of the <see cref="AccessControlSections"/> values that specifies the type of access control list (ACL) information to receive.</param>
        /// <returns>A <see cref="DirectorySecurity"/> object that encapsulates the access control rules for the file described by the path parameter.</returns>
        //DirectorySecurity GetAccessControl(AccessControlSections includeSections);

        /// <summary>
        /// Returns the subdirectories of the current directory.
        /// </summary>
        /// <returns>An array of DirectoryInfo objects.</returns>
        DirectoryInfo[] GetDirectories();

        /// <summary>
        /// Returns an array of directories in the current DirectoryInfo matching the given search criteria.
        /// </summary>
        /// <param name="searchPattern">The search string to match against the names of directories. This parameter can contain a combination of valid literal path and wildcard (* and ?) characters (see Remarks), but doesn't support regular expressions. The default pattern is "*", which returns all files.</param>
        /// <returns>An array of type DirectoryInfo matching searchPattern.</returns>
        DirectoryInfo[] GetDirectories(string searchPattern);

        /// <summary>
        /// Returns an array of directories in the current DirectoryInfo matching the given search criteria and using a value to determine whether to search subdirectories.
        /// </summary>
        /// <param name="searchPattern">The search string to match against the names of directories. This parameter can contain a combination of valid literal path and wildcard (* and ?) characters (see Remarks), but doesn't support regular expressions. The default pattern is "*", which returns all files.</param>
        /// <param name="searchOption">One of the enumeration values that specifies whether the search operation should include only the current directory or all subdirectories.</param>
        /// <returns>An array of type DirectoryInfo matching searchPattern.</returns>
        DirectoryInfo[] GetDirectories(string searchPattern, SearchOption searchOption);

        /// <summary>
        /// Returns a file list from the current directory.
        /// </summary>
        /// <returns>An array of type <see cref="FileInfo"/>.</returns>
        FileInfo[] GetFiles();

        /// <summary>
        /// Returns a file list from the current directory matching the given search pattern.
        /// </summary>
        /// <param name="searchPattern">The search string to match against the names of files. This parameter can contain a combination of valid literal path and wildcard (* and ?) characters (see Remarks), but doesn't support regular expressions. The default pattern is "*", which returns all files.</param>
        /// <returns>An array of type <see cref="FileInfo"/>.</returns>
        FileInfo[] GetFiles(string searchPattern);

        /// <summary>
        /// Returns a file list from the current directory matching the given search pattern and using a value to determine whether to search subdirectories.
        /// </summary>
        /// <param name="searchPattern">The search string to match against the names of files. This parameter can contain a combination of valid literal path and wildcard (* and ?) characters (see Remarks), but doesn't support regular expressions. The default pattern is "*", which returns all files.</param>
        /// <param name="searchOption">One of the enumeration values that specifies whether the search operation should include only the current directory or all subdirectories.</param>
        /// <returns>An array of type <see cref="FileInfo"/>.</returns>
        FileInfo[] GetFiles(string searchPattern, SearchOption searchOption);

        /// <summary>
        /// Returns an array of strongly typed FileSystemInfo entries representing all the files and subdirectories in a directory.
        /// </summary>
        /// <returns>An array of strongly typed <see cref="FileSystemInfo"/> entries.</returns>
        FileSystemInfo[] GetFileSystemInfos();

        /// <summary>
        /// Retrieves an array of strongly typed FileSystemInfo objects representing the files and subdirectories that match the specified search criteria.
        /// </summary>
        /// <param name="searchPattern">The search string to match against the names of directories and files. This parameter can contain a combination of valid literal path and wildcard (* and ?) characters (see Remarks), but doesn't support regular expressions. The default pattern is "*", which returns all files.</param>
        /// <returns>An array of strongly typed FileSystemInfo objects matching the search criteria.</returns>
        FileSystemInfo[] GetFileSystemInfos(string searchPattern);

        /// <summary>
        /// Retrieves an array of FileSystemInfo objects that represent the files and subdirectories matching the specified search criteria.
        /// </summary>
        /// <param name="searchPattern">The search string to match against the names of directories and filesa. This parameter can contain a combination of valid literal path and wildcard (* and ?) characters (see Remarks), but doesn't support regular expressions. The default pattern is "*", which returns all files.</param>
        /// <param name="searchOption">One of the enumeration values that specifies whether the search operation should include only the current directory or all subdirectories. The default value is TopDirectoryOnly.</param>
        /// <returns>An array of file system entries that match the search criteria.</returns>
        FileSystemInfo[] GetFileSystemInfos(string searchPattern, SearchOption searchOption);

        /// <summary>
        /// Serves as the default hash function.
        /// </summary>
        /// <returns>A hash code for the current object.</returns>
        int GetHashCode();

        /// <summary>
        /// Retrieves the current lifetime service object that controls the lifetime policy for this instance.
        /// </summary>
        /// <returns>An object of type ILease used to control the lifetime policy for this instance.</returns>
        //object GetLifetimeService();

        /// <summary>
        /// Sets the SerializationInfo object with the file name and additional exception information.
        /// </summary>
        /// <param name="info">The SerializationInfo that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The StreamingContext that contains contextual information about the source or destination.</param>
        //void GetObjectData(SerializationInfo info, StreamingContext context);

        /// <summary>
        /// Gets the Type of the current instance.
        /// </summary>
        /// <returns>The exact runtime type of the current instance.</returns>
        Type GetType();

        /// <summary>
        /// Obtains a lifetime service object to control the lifetime policy for this instance.
        /// </summary>
        /// <returns>An object of type ILease used to control the lifetime policy for this instance. This is the current lifetime service object for this instance if one exists; otherwise, a new lifetime service object initialized to the value of the LifetimeServices.LeaseManagerPollTime property.</returns>
        //object InitializeLifetimeService();

        /// <summary>
        /// Moves a DirectoryInfo instance and its contents to a new path.
        /// </summary>
        /// <param name="destDirName">The name and path to which to move this directory. The destination cannot be another disk volume or a directory with the identical name. It can be an existing directory to which you want to add this directory as a subdirectory.</param>
        void MoveTo(string destDirName);

        /// <summary>
        /// Refreshes the state of the object.
        /// </summary>
        void Refresh();

        /// <summary>
        /// Applies access control list (ACL) entries described by a DirectorySecurity object to the directory described by the current DirectoryInfo object.
        /// </summary>
        /// <param name="directorySecurity">An object that describes an ACL entry to apply to the directory described by the path parameter.</param>
        //void SetAccessControl(DirectorySecurity directorySecurity);

        /// <summary>
        /// Returns the original path that was passed by the user.
        /// </summary>
        /// <returns>Returns the original path that was passed by the user.</returns>
        string ToString();
    }
}