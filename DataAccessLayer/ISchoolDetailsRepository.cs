using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public interface ISchoolDetailsRepository
    {
        public SchoolDetailss InsertSP(SchoolDetailss SchoolDetail);
        public IEnumerable<SchoolDetailss> ReadSP();
        public SchoolDetailss FindSchoolDetailsByIdSP(long Id);
        public void DeleteSchoolDetailsByIdSP(long Id);
        public SchoolDetailss UpdateSchoolDetailsByIdSP(long Id, SchoolDetailss Sch);

    }
}
