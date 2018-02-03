using System;
namespace Patrones02.Campos
{
    public abstract class Field
    {
        private Boolean Valido;
        private String Valor;
        private validable validationB;

        public Field(String Valor, validable validationB)
        {
            this.Valor = Valor;
            this.validationB = validationB;
        }

        public Boolean getIsValid()
        {
            return this.Valido;
        }

        public void setValidatable(validable validationB)
        {
            this.validationB = validationB;
        }

        public void validate()
        {
            this.Valido = this.validationB.validate(this.Valor);
        }

        public String getValue()
        {
            return Valor;
        }

        public void setValue(String value)
        {
            this.Valor = Valor;
        }
    }
}