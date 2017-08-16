﻿using KeywordsSoft.Library.Database;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeywordsSoft.Library.Helpers
{
    public class ImagesHelper
    {
        private string Path = $@"{ConfigurationManager.AppSettings["DatabasePath"]}\images\";

        private string CreateCommand = @"CREATE TABLE images(
                                            id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, 
                                            key_id INTEGER,
                                            text TEXT,
                                            parser_id INTEGER);";

        private DatabaseRepository Database { get; set; }

        public ImagesHelper()
        {
            Database = new DatabaseRepository();
        }

        public void CreateDatabase(string name)
        {
            Database.Create(Path, name + "_images", CreateCommand);
        }

        public void DeleteDatabase(string name)
        {
            Database.Delete(Path + name + "_images");
        }

    }
}