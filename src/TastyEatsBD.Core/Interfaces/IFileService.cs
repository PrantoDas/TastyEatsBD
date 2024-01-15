using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TastyEatsBD.Core.Interfaces;
public interface IFileService
{
    /// <summary>
    /// Uploads a file stream and returns the URL where the file is stored.
    /// </summary>
    /// <param name="fileStream">The stream of the file to be uploaded.</param>
    /// <param name="fileName">The name of the file.</param>
    /// <returns>The URL of the uploaded file.</returns>
    Task<string> UploadFileAsync(Stream fileStream, string fileName);

    /// <summary>
    /// Deletes a file from the storage.
    /// </summary>
    /// <param name="filePath">The path of the file to be deleted.</param>
    /// <returns>True if deletion is successful, otherwise false.</returns>
    Task<bool> DeleteFileAsync(string filePath);

    /// <summary>
    /// Retrieves the file as a stream.
    /// </summary>
    /// <param name="filePath">The path of the file to retrieve.</param>
    /// <returns>The file stream.</returns>
    Task<Stream> GetFileStreamAsync(string filePath);

    /// <summary>
    /// Checks if a file exists at the given path.
    /// </summary>
    /// <param name="filePath">The file path to check.</param>
    /// <returns>True if the file exists, otherwise false.</returns>
    Task<bool> FileExistsAsync(string filePath);
    Task<byte[]> GetFileAsync(string filePath);
}

