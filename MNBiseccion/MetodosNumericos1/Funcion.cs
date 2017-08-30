﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Funcion
{
    /// <summary>
    /// Ejecuta la función 3.2(x)^2 + 2.7(x) - 1.3 ; recibe valor para X y retorna resultado
    /// </summary>
    /// <param name="x"></param>
    /// <returns></returns>
    /// 





    public static double EjecutarFuncion1(double x)
    {
        double result = 0;
        result = 3.2 * (Math.Pow(x, 2)) + 2.7 * (x) - 1.3;
        return result;
    }

    public static double EjecutarFuncion2(double x)
    {
        double result = 0;
        result = Math.Exp(-x) - 3.7;
        return result;
    }

    public static double EjecutarFuncion3(double x)
    {
        double result = 0;
        result = 3.2 * (Math.Pow(x, 2)) - Math.Exp(x);
        return result;
    }

    public static double EjecutarFuncion4(double x)
    {
        double result = 0;
        result = x - Math.Cos(x);
        return result;
    }

    public static double EjecutarFuncion5(double x)
    {
        double result = 0;
        result = Math.Sin(x) - (2 * Math.Cos(x));
        return result;
    }

    public static double EjecutarFuncion6(double x)
    {
        double result = 0;
        result = Math.Cos(x) + Math.Pow(((1 + (Math.Pow(x, 2)))), (-1));
        return result;
    }

    public static double EjecutarFuncion7(double x)
    {
        double result = 0;
        result = (Math.Pow(x - 2, 2)) - Math.Log(x);
        return result;
    }
    public static double ObtenerX2(double x0, double x1)
    {
        double result = 0;
        result = (x0 + x1) / 2;
        return result;
    }

   
}

