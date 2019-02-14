using System;
using System.Collections.Generic;

namespace DDApi.Model
{
    public class GetDepartmentListModel
    {
        public List<DepartmentInfo> department { get; set; }

        public int errcode { get; set; }

        public string errmsg { get; set; }
    }
}
