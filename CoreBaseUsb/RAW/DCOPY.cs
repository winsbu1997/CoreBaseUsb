using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using CoreBaseUsb.Utilities;

namespace CoreBaseUsb.RAW
{
    public class DCOPY
    {
        // Token: 0x0600000C RID: 12 RVA: 0x00003624 File Offset: 0x00001824
        public static long DirSize_files(string path)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            long num = 0L;
            foreach (FileInfo fileInfo in directoryInfo.GetFiles("*.*"))
            {
                num += fileInfo.Length;
            }
            return num;
        }

        // Token: 0x0600000D RID: 13 RVA: 0x00003674 File Offset: 0x00001874
        public static long DirSize_All(string path)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            long num = 0L;
            foreach (FileInfo fileInfo in directoryInfo.GetFiles("*.*"))
            {
                num += fileInfo.Length;
            }
            long num2 = 0L;
            int num3 = 0;
            foreach (DirectoryInfo directoryInfo2 in directoryInfo.GetDirectories())
            {
                num3++;
            }
            long result;
            if (num3 == 0)
            {
                result = num;
            }
            else
            {
                foreach (DirectoryInfo directoryInfo2 in directoryInfo.GetDirectories())
                {
                    num2 += DCOPY.DirSize_All(directoryInfo2.FullName);
                }
                long num4 = num2 + num;
                result = num4;
            }
            return result;
        }

        // Token: 0x0600000E RID: 14 RVA: 0x00003748 File Offset: 0x00001948
        public static long DirCount_files(string path)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            return (long)directoryInfo.GetFiles("*.*").Length;
        }

        // Token: 0x0600000F RID: 15 RVA: 0x00003778 File Offset: 0x00001978
        public static ArrayList TraverseDOSTree(string root)
        {
            ArrayList arrayList = new ArrayList();
            Stack<string> stack = new Stack<string>(20);
            if (!Directory.Exists(root))
            {
                throw new ArgumentException();
            }
            stack.Push(root);
            while (stack.Count > 0)
            {
                string path = stack.Pop();
                string[] directories;
                try
                {
                    directories = Directory.GetDirectories(path);
                }
                catch (UnauthorizedAccessException ex)
                {
                    Console.WriteLine(ex.Message);
                    continue;
                }
                catch (DirectoryNotFoundException ex2)
                {
                    Console.WriteLine(ex2.Message);
                    continue;
                }
                string[] array = null;
                try
                {
                    array = Directory.GetFiles(path);
                }
                catch (UnauthorizedAccessException ex)
                {
                    Console.WriteLine(ex.Message);
                    continue;
                }
                catch (DirectoryNotFoundException ex2)
                {
                    Console.WriteLine(ex2.Message);
                    continue;
                }
                foreach (string fileName in array)
                {
                    try
                    {
                        FileInfo value = new FileInfo(fileName);
                        arrayList.Add(value);
                    }
                    catch (FileNotFoundException ex3)
                    {
                        Console.WriteLine(ex3.Message);
                    }
                }
                foreach (string item in directories)
                {
                    stack.Push(item);
                }
            }
            return arrayList;
        }

        // Token: 0x06000010 RID: 16 RVA: 0x000038D0 File Offset: 0x00001AD0
        public static bool CopyDOSFolderContents(string SourcePath, string DestinationPath)
        {
            SourcePath = (SourcePath.EndsWith("\\") ? SourcePath : (SourcePath + "\\"));
            DestinationPath = (DestinationPath.EndsWith("\\") ? DestinationPath : (DestinationPath + "\\"));
            bool result;
            try
            {
                if (Directory.Exists(SourcePath))
                {
                    if (!Directory.Exists(DestinationPath))
                    {
                        Directory.CreateDirectory(DestinationPath);
                    }
                    foreach (string fileName in Directory.GetFiles(SourcePath))
                    {
                        FileInfo fileInfo = new FileInfo(fileName);
                        fileInfo.CopyTo(string.Format("{0}\\{1}", DestinationPath, fileInfo.Name), true);
                    }
                    foreach (string text in Directory.GetDirectories(SourcePath))
                    {
                        DirectoryInfo directoryInfo = new DirectoryInfo(text);
                        if (!DCOPY.CopyDOSFolderContents(text, DestinationPath + directoryInfo.Name))
                        {
                            return false;
                        }
                    }
                }
                result = true;
            }
            catch
            {
                result = false;
            }
            return result;
        }

        // Token: 0x06000011 RID: 17 RVA: 0x000022AB File Offset: 0x000004AB
        public DCOPY()
        {
            Class3.vd4OXo2zYFEgU();
            //base..ctor();
        }

        // Token: 0x06000012 RID: 18 RVA: 0x000022C9 File Offset: 0x000004C9
        static DCOPY()
        {
            Class3.vd4OXo2zYFEgU();
            DCOPY.ENABLE_COPY_DIR = null;
        }

        // Token: 0x0400000B RID: 11
        public static ArrayList ENABLE_COPY_DIR;

        // Token: 0x02000006 RID: 6
        public struct dirInfo
        {
            // Token: 0x0400000C RID: 12
            public string dirPath;

            // Token: 0x0400000D RID: 13
            public string dirName;

            // Token: 0x0400000E RID: 14
            public int dirLevel;
        }
    }
}
