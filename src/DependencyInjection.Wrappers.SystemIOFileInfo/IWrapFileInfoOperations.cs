using System;
using System.IO;

namespace DependencyInjection.Wrappers.SystemIOFileInfo
{
    public interface IWrapFileInfoOperations
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
        /// Gets an instance of the parent directory.
        /// </summary>
        DirectoryInfo Directory { get; }

        /// <summary>
        /// Gets a string representing the directory's full path.
        /// </summary>
        string DirectoryName { get; }

        /// <summary>
        /// Gets a value indicating whether a file exists.
        /// </summary>
        bool Exists { get; }

        /// <summary>
        /// Gets the string representing the extension part of the file.
        /// </summary>
        string Extension { get; }

        FileInfo FileInfo { get; }

        /// <summary>
        /// Gets the full path of the directory or file.
        /// </summary>
        string FullName { get; }

        /// <summary>
        /// Gets or sets a value that determines if the current file is read only.
        /// </summary>
        bool IsReadOnly { get; set; }

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
        /// Gets the size, in bytes, of the current file.
        /// </summary>
        long Length { get; }

        /// <summary>
        /// Gets the name of the file.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Creates a <see cref="StreamWriter"/> that appends text to the file represented by this instance of the <see cref="FileInfo"/>.
        /// </summary>
        /// <returns>A new <see cref="StreamWriter"/>.</returns>
        StreamWriter AppendText();

        /// <summary>
        /// Copies an existing file to a new file, disallowing the overwriting of an existing file.
        /// </summary>
        /// <param name="destFileName">The name of the new file to copy to.</param>
        /// <returns>A new file with a fully qualified path.</returns>
        FileInfo CopyTo(string destFileName);

        /// <summary>
        /// Copies an existing file to a new file, allowing the overwriting of an existing file.
        /// </summary>
        /// <param name="destFileName">The name of the new file to copy to.</param>
        /// <param name="overwrite">true to allow an existing file to be overwritten; otherwise, false.</param>
        /// <returns>A new file, or an overwrite of an existing file if overwrite is true. If the file exists and overwrite is false, an <see cref="IOException"/> is thrown.</returns>
        FileInfo CopyTo(string destFileName, bool overwrite);

        /// <summary>
        /// Creates a file.
        /// </summary>
        /// <returns>A new file.</returns>
        FileStream Create();

        /// <summary>
        /// Creates a new <see cref="FileInfo"/> at the specified path with the specified file name.
        /// </summary>
        /// <param name="fileName">The fully qualified name of the new file, or the relative file name. Do not end the path with the directory separator character.</param>
        void Create(string fileName);

        /// <summary>
        /// Creates an object that contains all the relevant information required to generate a proxy used to communicate with a remote object.
        /// </summary>
        /// <param name="requestedType">The <see cref="Type"/> of the object that the new <see cref="ObjRef"/> will reference.</param>
        /// <returns>Information required to generate a proxy.</returns>
        //ObjRef CreateObjRef(Type requestedType);

        /// <summary>
        /// Creates a StreamWriter that writes a new text file.
        /// </summary>
        /// <returns>A new <see cref="StreamWriter"/></returns>
        StreamWriter CreateText();

        /// <summary>
        /// Permanently deletes a file.
        /// </summary>
        void Delete();

        /// <summary>
        /// Determines whether the specified object is equal to the current object.
        /// </summary>
        /// <param name="obj">The object to compare with the current object.</param>
        /// <returns>true if the specified object is equal to the current object; otherwise, false.</returns>
        bool Equals(object obj);

        /// <summary>
        /// Gets a <see cref="FileSecurity"/> object that encapsulates the access control list (ACL) entries for the file described by the current FileInfo object.
        /// </summary>
        /// <returns>A <see cref="FileSecurity"/> object that encapsulates the access control rules for the current file.</returns>
        //FileSecurity GetAccessControl();

        /// <summary>
        /// Gets a <see cref="FileSecurity"/> object that encapsulates the specified type of access control list (ACL) entries for the file described by the current <see cref="FileInfo"/> object.
        /// </summary>
        /// <param name="includeSections">One of the <see cref="AccessControlSections"/> values that specifies which group of access control entries to retrieve.</param>
        //FileSecurity GetAccessControl(AccessControlSections includeSections);

        /// <summary>
        /// Serves as the default hash function.
        /// </summary>
        /// <returns>A hash code for the current object.</returns>
        int GetHashCode();

        /// <summary>
        /// Retrieves the current lifetime service object that controls the lifetime policy for this instance.
        /// </summary>
        /// <returns>An object of type <see cref="ILease"/> used to control the lifetime policy for this instance.</returns>
        //object GetLifetimeService();

        /// <summary>
        /// Sets the SerializationInfo object with the file name and additional exception information.
        /// </summary>
        /// <param name="info">The <see cref="SerializationInfo"/> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="StreamingContext"/> that contains contextual information about the source or destination.</param>
        //void GetObjectData(SerializationInfo info, StreamingContext context);

        /// <summary>
        /// The exact runtime type of the current instance.
        /// </summary>
        Type GetType();

        /// <summary>
        /// Obtains a lifetime service object to control the lifetime policy for this instance.
        /// </summary>
        /// <returns>An object of type <see cref="ILease"/> used to control the lifetime policy for this instance. This is the current lifetime service object for this instance if one exists; otherwise, a new lifetime service object initialized to the value of the <see cref="LifetimeServices.LeaseManagerPollTime"/> property.</returns>
        //object InitializeLifetimeService();

        /// <summary>
        /// Moves a specified file to a new location, providing the option to specify a new file name.
        /// </summary>
        /// <param name="destFileName">The path to move the file to, which can specify a different file name.</param>
        void MoveTo(string destFileName);

        /// <summary>
        /// Opens a file in the specified mode.
        /// </summary>
        /// <param name="mode">A <see cref="FileMode"/> constant specifying the mode (for example, Open or Append) in which to open the file.</param>
        /// <returns>A file opened in the specified mode, with read/write access and unshared.</returns>
        FileStream Open(FileMode mode);

        /// <summary>
        /// Opens a file in the specified mode with read, write, or read/write access.
        /// </summary>
        /// <param name="mode">A <see cref="FileMode"/> constant specifying the mode (for example, Open or Append) in which to open the file.</param>
        /// <param name="access">A <see cref="FileAccess"/> constant specifying whether to open the file with Read, Write, or ReadWrite file access.</param>
        /// <returns>A <see cref="FileStream"/> object opened in the specified mode and access, and unshared.</returns>
        FileStream Open(FileMode mode, FileAccess access);

        /// <summary>
        /// Opens a file in the specified mode with read, write, or read/write access and the specified sharing option.
        /// </summary>
        /// <param name="mode">A <see cref="FileMode"/> constant specifying the mode (for example, Open or Append) in which to open the file.</param>
        /// <param name="access">A <see cref="FileAccess"/> constant specifying whether to open the file with Read, Write, or ReadWrite file access.</param>
        /// <param name="share">A <see cref="FileShare"/> constant specifying the type of access other FileStream objects have to this file.</param>
        /// <returns>A <see cref="FileStream"/> object opened with the specified mode, access, and sharing options.</returns>
        FileStream Open(FileMode mode, FileAccess access, FileShare share);

        /// <summary>
        /// Creates a read-only <see cref="FileStream"/>.
        /// </summary>
        /// <returns>A new read-only <see cref="FileStream"/> object.</returns>
        FileStream OpenRead();

        /// <summary>
        /// Creates a <see cref="StreamReader"/> with UTF8 encoding that reads from an existing text file.
        /// </summary>
        /// <returns>A new <see cref="StreamReader"/> with UTF8 encoding.</returns>
        StreamReader OpenText();

        /// <summary>
        /// Creates a write-only FileStream.
        /// </summary>
        /// <returns>A write-only unshared <see cref="FileStream"/> object for a new or existing file.</returns>
        FileStream OpenWrite();

        /// <summary>
        /// Refreshes the state of the object.
        /// </summary>
        void Refresh();

        /// <summary>
        /// Replaces the contents of a specified file with the file described by the current FileInfo object, deleting the original file, and creating a backup of the replaced file.
        /// </summary>
        /// <param name="destinationFileName">The name of a file to replace with the current file.</param>
        /// <param name="destinationBackupFileName">The name of a file with which to create a backup of the file described by the destFileName parameter.</param>
        /// <returns>A <see cref="FileInfo"/> object that encapsulates information about the file described by the destFileName parameter.</returns>
        //FileInfo Replace(string destinationFileName, string destinationBackupFileName);

        /// <summary>
        /// Replaces the contents of a specified file with the file described by the current FileInfo object, deleting the original file, and creating a backup of the replaced file. Also specifies whether to ignore merge errors.
        /// </summary>
        /// <param name="destinationFileName">The name of a file to replace with the current file.</param>
        /// <param name="destinationBackupFileName">The name of a file with which to create a backup of the file described by the destFileName parameter.</param>
        /// <param name="ignoreMetadataErrors">true to ignore merge errors (such as attributes and ACLs) from the replaced file to the replacement file; otherwise false.</param>
        /// <returns>A <see cref="FileInfo"/> object that encapsulates information about the file described by the destFileName parameter.</returns>
        //FileInfo Replace(string destinationFileName, string destinationBackupFileName, bool ignoreMetadataErrors);

        /// <summary>
        /// Applies access control list (ACL) entries described by a FileSecurity object to the file described by the current FileInfo object.
        /// </summary>
        /// <param name="fileSecurity">A <see cref="FileSecurity"/> object that describes an access control list (ACL) entry to apply to the current file.</param>
        //void SetAccessControl(FileSecurity fileSecurity);

        /// <summary>
        /// Returns the path as a string.
        /// </summary>
        /// <returns>A string representing the path.</returns>
        string ToString();
    }
}