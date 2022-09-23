using System;

public enum TipoDeExtraccion
{
    CajeroHumano = 1,
    CajeroAutomatico = 2
}

public class Cuenta
{
    public decimal saldo;
    public TipoDeExtraccion tipo;

    public bool insercion(decimal monto)
    {
        saldo += monto;
        return true;
    }

    bool extraccion(TipoDeExtraccion tipo, decimal monto)
    {
        return false;
    }

    public class CuentaCorrientePesos
    {
        bool extraccion(TipoDeExtraccion tipo, decimal monto)
        {
            decimal saldoDespuesDeLaOperacion = saldo - monto;
            if (saldoDespuesDeLaOperacion >= -5000)
            {
                saldo -= monto;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    public class CuentaCorrienteDolares
    {
        bool extraccion(TipoDeExtraccion tipo, decimal monto)
        {
            decimal saldoDespuesDeLaOperacion = saldo - monto;
            if (saldoDespuesDeLaOperacion >= 0)
            {
                saldo -= monto;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    public class CajaAhorroPesos
    {
        bool extraccion(TipoDeExtraccion tipo, decimal monto)
        {
            decimal saldoDespuesDeLaOperacion = saldo - monto;
            if (saldoDespuesDeLaOperacion >= 0)
            {
                saldo -= monto;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
