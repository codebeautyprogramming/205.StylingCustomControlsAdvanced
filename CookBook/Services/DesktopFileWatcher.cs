﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookBook.Services
{
    public class DesktopFileWatcher
    {
        private static volatile DesktopFileWatcher _instance;
        private static readonly object _lock = new object();
        public static bool CurrentFileStatus { get; set; }

        private BackgroundWorker _fileCheckWorker;
        public event Action<bool> OnFileStatusChanged;

        public int PreparedRecipesCounter { get; set; }
        public static DesktopFileWatcher Instance
        {
            get 
            {
                if(_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new DesktopFileWatcher();
                        }
                    }
                }

                return _instance;
            }
        }

        private DesktopFileWatcher() {
            _fileCheckWorker = new BackgroundWorker();
            _fileCheckWorker.DoWork += FileCheckWorker_DoWork;
            _fileCheckWorker.RunWorkerAsync();
        }

        private void FileCheckWorker_DoWork(object? sender, DoWorkEventArgs e)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePath = Path.Combine(desktopPath, "ShoppingList.txt");

            CurrentFileStatus= false;

            while (true)
            {
                bool fileExists = File.Exists(filePath);
                if(CurrentFileStatus != fileExists)
                {
                    FileStatusChanged(fileExists);
                    CurrentFileStatus = fileExists;
                }
                Thread.Sleep(1000);
            }
        }

        private void FileStatusChanged(bool fileExists)
        {
            if (OnFileStatusChanged != null)
                OnFileStatusChanged.Invoke(fileExists);
        }
    }
}
