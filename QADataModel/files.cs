using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QADataModel
{
    public class files
    {
        public class fileSpec
        {
            public Guid row_idnumber { get; set; }
            public Guid project_idnumber { get; set; }

            public string file_name { get; set; }
            public string sender { get; set; }
            public string recipient { get; set; }
            public string frequency { get; set; }
            public string transfer_time { get; set; }
            public string file_type { get; set; }
            public string file_format { get; set; }
            public string header_row { get; set; }
            public string file_encryption { get; set; }
            public string transfer_method { get; set; }
            public string file_description { get; set; }
            public string notes { get; set; }
            public int inbound = 0;
            public int outbound = 0;
            public string delimitor { get; set; }
            public string filename_prefix { get; set; }
            public string filename_ext { get; set; }


            public Int32 Status = 1;
        }
        public class fileSpecRoot
        {
            public fileSpec fileSpecs { get; set; }
        }
        public class fileSpecObject
        {
            public List<fileSpec> fileSpecs { get; set; }
        }


        public class fieldSpec
        {
            public Guid row_idnumber { get; set; }
            public Guid file_idnumber { get; set; }
            public string field_name { get; set; }
            public string field_desc { get; set; }
            public int field_order_num = 0;
            public string data_type { get; set; }
            public int max_length = 0;
            public string format_mask { get; set; }
            public string is_required { get; set; }
            public string is_file_primary_key { get; set; }
            public string is_part_of_file_key { get; set; }
            public string has_allowedvalues { get; set; }
            public string allowedvalues { get; set; }
            public int min_lengh = 0;
            public int field_pos = 0;
            public int column_width = 0;
            public string filler_char { get; set; }
            public string allignment { get; set; }

            public int Status { get; set; }
        }

        public class fieldSpecRoot
        {
            public fieldSpec fieldSpecs { get; set; }
        }
        public class fieldSpecObject
        {
            public List<fieldSpec> fieldSpecs { get; set; }
        }
    }
}
