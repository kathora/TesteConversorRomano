using ConversorNumeroRomano;
using System;
using System.Diagnostics.CodeAnalysis;
using Xunit;

namespace ClassLibrary2
{
    [ExcludeFromCodeCoverage]
    public class ConversorDeNumeroRomanoTest
    {
        [Fact]
        public void DeveEntenderOSimboloI()
        {
            ConversorDeNumeroRomano romano = new ConversorDeNumeroRomano();
            string numero = romano.Converte(1);
            Assert.Equal("I", numero);

        }

        [Fact]
        public void DeveEntenderOSimboloV()
        {
            ConversorDeNumeroRomano romano = new ConversorDeNumeroRomano();
            string numero = romano.Converte(5);
            Assert.Equal("V", numero);

        }
    }
}
