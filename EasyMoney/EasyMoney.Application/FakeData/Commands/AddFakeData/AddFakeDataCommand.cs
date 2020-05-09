using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EasyMoney.Application.FakeData.Commands.AddFakeData
{
    public class AddFakeDataCommand : IRequest<string>
    {
        public string Value1 { get; set; }
        public int Value2 { get; set; }
        public DateTime Value3 { get; set; }
        public IEnumerable<string> Value4 { get; set; }

        public override string ToString()
        {
            return $"custom to string, { Value4.FirstOrDefault() }";
        }
    }
}
