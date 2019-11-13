using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FileComparisonTool
{
    public class FileModel
    {
        /// <summary>
        /// 目录
        /// </summary>
        public string Path { get; set; }

        /// <summary>
        /// 文件
        /// </summary>
        public List<string> Files { get; set; }

        /// <summary>
        /// 子目录
        /// </summary>
        public List<FileModel> Childs { get; set; } = new List<FileModel>();
    }
}
