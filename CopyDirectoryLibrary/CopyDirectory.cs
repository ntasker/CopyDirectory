using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyDirectoryLibrary
{
    public class CopyDirectory
    {
        private Progress<string> progress;

        public CopyDirectory(Progress<string> progress)
        {

            this.progress = progress;
        }

        public void CopyDir(string sourcePath, string destinationPath)
        {

            ValidateSourceDirectory(sourcePath);

            DirectoryInfo SourceDirectory = new DirectoryInfo(sourcePath);
            DirectoryInfo DestingationDirectory = new DirectoryInfo(destinationPath);

            //pass directories to recursive method
            CopyAll(SourceDirectory, DestingationDirectory);
        }

        private void CopyAll(DirectoryInfo source, DirectoryInfo destination)
        {

            Directory.CreateDirectory(destination.FullName);

            //Copy each file into the directory
            foreach (FileInfo fileInfo in source.GetFiles())
            {
                fileInfo.CopyTo(Path.Combine(destination.FullName, fileInfo.Name), true);
                //update progress
                String fileCopied = "Copying: " + destination.FullName + " \\ " + fileInfo.Name;
                ((IProgress<string>)progress)?.Report(fileCopied);
            }

            //Copy every subdirectory using recursion
            foreach (DirectoryInfo sourceSubdirectory in source.GetDirectories())
            {
                DirectoryInfo nextDestSubdirectory = destination.CreateSubdirectory(sourceSubdirectory.Name);

                CopyAll(sourceSubdirectory, nextDestSubdirectory);
            }
        }

        //Ensure that the source directory the user has chosen is valid
        private static void ValidateSourceDirectory(string sourcePath)
        {
            DirectoryInfo directory = new DirectoryInfo(sourcePath);

            if (!directory.Exists)
            {
                throw new DirectoryNotFoundException("The soruce folder selected does not exist " + sourcePath);
            }
        }



    }
}
