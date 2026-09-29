using Program;
using System;
using System.Collections.Generic;

public class Szerviz
{
    private List<Jarmu> jarmuvek = new List<Jarmu>();

    public void JarmuFelvetele(Jarmu jarmu)
    {
        jarmuvek.Add(jarmu);
        Console.WriteLine($"A {jarmu.Rendszam} rendszámú 🚗 meg jott  a szervizbe");
    }

    public void InformaciokListazasa()
    {
        foreach (Jarmu jarmu in jarmuvek)
        {
            jarmu.Infotad();
        }
    }

    public void CsoportosSzerviz(int dij)
    {
        foreach (Jarmu jarmu in jarmuvek)
        {
            if (jarmu.Szervizszukseges)
            {
                jarmu.Szervizel(dij);
            }
            else
            {
                Console.WriteLine(
                    $"A {jarmu.Rendszam} szerivize jelenleg nem szukseges mivel jó állapotba van 🚗 : D "
                );
            }
        }
    }
}
