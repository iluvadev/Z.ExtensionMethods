using System;
using System.IO;

public static partial class Extensions
{
    /// <summary>
    /// Retorna si el fitxer està bloquejat
    /// </summary>
    /// <param name="fi"></param>
    /// <returns></returns>
    public static bool IsFileLocked(this FileInfo fi)
    {
        FileStream stream = null;

        try
        {
            stream = fi.Open(FileMode.Open, FileAccess.ReadWrite, FileShare.None);
        }
        catch (IOException)
        {
            //the file is unavailable because it is:
            //still being written to
            //or being processed by another thread
            //or does not exist (has already been processed)
            return true;
        }
        finally
        {
            if (stream != null)
                stream.Close();
        }

        //file is not locked
        return false;
    }
}