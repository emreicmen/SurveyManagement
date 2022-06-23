using EntityLayer.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    //Database işlemleri sırasında olabilecek hataları ve sonuçları döndğrecek sınıfı yazarak bu işlemlerin her birini ayrı ayrı başka sınıflarda yapmadık.
    public class BusinessLayerResult<T> where T : class
    {
        public List<ErrorMessageObj> Errors { get; set; }
        public T Result { get; set; }
        public BusinessLayerResult()
        {
            Errors = new List<ErrorMessageObj>();
        }
        public void AddError(ErrorMessageCode code, string message)
        {
            Errors.Add(new ErrorMessageObj() { Code = code, Message = message });

        }
    }
}
