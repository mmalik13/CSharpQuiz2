using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz2 {
    class FileIO {

        public void CreateFile(string content, string path) {
            FileStream stream =
                new FileStream(path, FileMode.Append);
            using (StreamWriter writer = new StreamWriter(stream)) {
                writer.WriteLine(content);
            }
        }

        public void DeleteFile(string path) {
            try {
                File.Delete(path);
            }

            catch (Exception exc) {
                //Log system
                Console.Write(exc.Message);
            }
        }

        public int NumberOfUsers(string path) {
            if (!File.Exists(path)) {
                FileStream stream = new FileStream(path, FileMode.Append);
                stream.Close();
            }
                var lineCount = 0;
                using (var reader = File.OpenText(path)) {
                    while (reader.ReadLine() != null) {
                        lineCount++;
                    }
                }
                return lineCount;
            
           
        }
    }
}
