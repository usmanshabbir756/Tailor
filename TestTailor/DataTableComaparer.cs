using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTailor
{
    internal class DataTableComaparer
    {
        public static bool AreEqual(DataTable dt1, DataTable dt2)
        {
            if (dt1 == null || dt2 == null)
            {
                return false;
            }

            // Compare table structure
            if (dt1.Columns.Count != dt2.Columns.Count)
            {
                return false;
            }

            for (int i = 0; i < dt1.Columns.Count; i++)
            {
                if (dt1.Columns[i].ColumnName != dt2.Columns[i].ColumnName ||
                    dt1.Columns[i].DataType != dt2.Columns[i].DataType)
                {
                    return false;
                }
            }

            // Compare data
            if (dt1.Rows.Count != dt2.Rows.Count)
            {
                return true;
            }

            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                for (int j = 0; j < dt1.Columns.Count; j++)
                {
                    if (!object.Equals(dt1.Rows[i][j], dt2.Rows[i][j]))
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
