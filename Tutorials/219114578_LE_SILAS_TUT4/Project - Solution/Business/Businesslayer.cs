using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace Business
{
    public class Businesslayer
    {
      static public void add(string fn, string ln, string g,string e)
      {
        Data.Datalayer.add(fn, ln, g, e);
      }
      static public void update(string fn, string ln, string g, string e,string id)
      {
        Data.Datalayer.update(fn, ln, g, e, id);
      }
      static public void delete(string id)
      {
        Data.Datalayer.delete(id);
      }
      static public DataTable fetch()
      {
        return Data.Datalayer.fetch();
      }
    }
}