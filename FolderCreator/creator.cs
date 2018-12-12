using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace FolderCreator
{
    public class creator
    {
        public creator()
        {

        }

        public string FolderRequirements(string folderPath, string projectDate, string projectName)
        {
            try
            {
                var newPath = $"{folderPath}\\{projectDate}\\{projectName}";


                if (Directory.Exists(newPath))
                {
                    return "Project already exits!";
                }
                else
                {
                    var subfolderNames = new List<string>
                    {
                        "Catalog",
                        "Raw",
                        "Selects",
                        "Final",
                        "Videos"
                    };

                    Directory.CreateDirectory(projectName);

                    for (int i = 0; i < subfolderNames.Count; i++)
                    {
                        var secondSubfolder = $"{folderPath}\\{projectDate}\\{projectName}\\{subfolderNames[i]}";
                        Directory.CreateDirectory(secondSubfolder);

                        Process.Start(newPath);
                    }

                }

                return "Folder Has been Created!";
            }
            catch (Exception error)
            {
                return error.Message;
            }
        }
    }
}
