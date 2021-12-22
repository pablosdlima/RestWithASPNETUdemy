using System.Collections.Generic;

namespace RestWithASPNETUdemy.Data.Convert.Contract
{
    public interface IParser<O, D> //origem e destino
    {
        D Parse(O origin);
        List<D> Parse(List<O> origin);
    }
}
