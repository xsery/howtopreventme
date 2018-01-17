using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonsEscolaDuvida : MonoBehaviour {

    public GameObject Cena1;
    public GameObject Cena2;
    public GameObject CenaFinal;
    public GameObject Opcoes;
    public GameObject Fundo;
    public GameObject Sala;
    public GameObject VideoDIU;
    public GameObject VideoCamisinhaFeminina;
    public GameObject VideoDiafragma;
    public GameObject CenaCamisinha;
    public GameObject CenaPilulaDiaSeguinte;
    public GameObject CenaPilulaAnticoncepcional1;
    public GameObject CenaPilulaAnticoncepcional2;
    public GameObject CenaDIU;
    public GameObject CenaInjecaoAnticoncepcional1;
    public GameObject CenaInjecaoAnticoncepcional2;
    public GameObject CenaCamisinhaFeminina;
    public GameObject CenaDiafragma;
    public GameObject CenaVideoDIU1;
    public GameObject VideoCamisinhaFeminina1;
    public GameObject VideoDiafragma1;

    public void IrCena1()
    {
        Cena1.SetActive(true);
        Cena2.SetActive(false);
        CenaFinal.SetActive(false);
        Opcoes.SetActive(false);
        Sala.SetActive(true);
        VideoDIU.SetActive(false);
        VideoCamisinhaFeminina.SetActive(false);
        VideoDiafragma.SetActive(false);
        CenaCamisinha.SetActive(false);
        CenaPilulaDiaSeguinte.SetActive(false);
        CenaPilulaAnticoncepcional1.SetActive(false);
        CenaPilulaAnticoncepcional2.SetActive(false);
        CenaDIU.SetActive(false);
        CenaInjecaoAnticoncepcional1.SetActive(false);
        CenaInjecaoAnticoncepcional2.SetActive(false);
        CenaCamisinhaFeminina.SetActive(false);
        CenaDiafragma.SetActive(false);
        CenaVideoDIU1.SetActive(false);
        VideoCamisinhaFeminina1.SetActive(false);
        VideoDiafragma1.SetActive(false);
    }

    // Use this for initialization
    void Start()
    {
        IrCena1();
    }

    public void IrCena2()
    {
        Cena1.SetActive(false);
        Cena2.SetActive(true);
        CenaFinal.SetActive(false);
        Opcoes.SetActive(false);
        Fundo.SetActive(false);
        Sala.SetActive(true);
        VideoDIU.SetActive(false);
        VideoCamisinhaFeminina.SetActive(false);
        VideoDiafragma.SetActive(false);
        CenaCamisinha.SetActive(false);
        CenaPilulaDiaSeguinte.SetActive(false);
        CenaPilulaAnticoncepcional1.SetActive(false);
        CenaPilulaAnticoncepcional2.SetActive(false);
        CenaDIU.SetActive(false);
        CenaInjecaoAnticoncepcional1.SetActive(false);
        CenaInjecaoAnticoncepcional2.SetActive(false);
        CenaCamisinhaFeminina.SetActive(false);
        CenaDiafragma.SetActive(false);
        CenaVideoDIU1.SetActive(false);
        VideoCamisinhaFeminina1.SetActive(false);
        VideoDiafragma1.SetActive(false);
    }

    public void IrCenaFinal()
    {
        Cena1.SetActive(false);
        Cena2.SetActive(false);
        CenaFinal.SetActive(true);
        Opcoes.SetActive(false);
        Fundo.SetActive(false);
        Sala.SetActive(true);
        VideoDIU.SetActive(false);
        VideoCamisinhaFeminina.SetActive(false);
        VideoDiafragma.SetActive(false);
        CenaCamisinha.SetActive(false);
        CenaPilulaDiaSeguinte.SetActive(false);
        CenaPilulaAnticoncepcional1.SetActive(false);
        CenaPilulaAnticoncepcional2.SetActive(false);
        CenaDIU.SetActive(false);
        CenaInjecaoAnticoncepcional1.SetActive(false);
        CenaInjecaoAnticoncepcional2.SetActive(false);
        CenaCamisinhaFeminina.SetActive(false);
        CenaDiafragma.SetActive(false);
        CenaVideoDIU1.SetActive(false);
        VideoCamisinhaFeminina1.SetActive(false);
        VideoDiafragma1.SetActive(false);
    }

    public void IrOpcoes()
    {
        Cena1.SetActive(false);
        Cena2.SetActive(false);
        CenaFinal.SetActive(false);
        Opcoes.SetActive(true);
        Fundo.SetActive(true);
        Sala.SetActive(false);
        VideoDIU.SetActive(false);
        VideoCamisinhaFeminina.SetActive(false);
        VideoDiafragma.SetActive(false);
        CenaCamisinha.SetActive(false);
        CenaPilulaDiaSeguinte.SetActive(false);
        CenaPilulaAnticoncepcional1.SetActive(false);
        CenaPilulaAnticoncepcional2.SetActive(false);
        CenaDIU.SetActive(false);
        CenaInjecaoAnticoncepcional1.SetActive(false);
        CenaInjecaoAnticoncepcional2.SetActive(false);
        CenaCamisinhaFeminina.SetActive(false);
        CenaDiafragma.SetActive(false);
        CenaVideoDIU1.SetActive(false);
        VideoCamisinhaFeminina1.SetActive(false);
        VideoDiafragma1.SetActive(false);
    }

    public void IrCamisinha()
    {
        Cena1.SetActive(false);
        Cena2.SetActive(false);
        CenaFinal.SetActive(false);
        Opcoes.SetActive(false);
        Fundo.SetActive(true);
        Sala.SetActive(false);
        VideoDIU.SetActive(false);
        VideoCamisinhaFeminina.SetActive(false);
        VideoDiafragma.SetActive(false);
        CenaCamisinha.SetActive(true);
        CenaPilulaDiaSeguinte.SetActive(false);
        CenaPilulaAnticoncepcional1.SetActive(false);
        CenaPilulaAnticoncepcional2.SetActive(false);
        CenaDIU.SetActive(false);
        CenaInjecaoAnticoncepcional1.SetActive(false);
        CenaInjecaoAnticoncepcional2.SetActive(false);
        CenaCamisinhaFeminina.SetActive(false);
        CenaDiafragma.SetActive(false);
        CenaVideoDIU1.SetActive(false);
        VideoCamisinhaFeminina1.SetActive(false);
        VideoDiafragma1.SetActive(false);

    }

    public void IrCenaPilulaDiaSeguinte()
    {
        Cena1.SetActive(false);
        Cena2.SetActive(false);
        CenaFinal.SetActive(false);
        Opcoes.SetActive(false);
        Fundo.SetActive(true);
        Sala.SetActive(false);
        VideoDIU.SetActive(false);
        VideoCamisinhaFeminina.SetActive(false);
        VideoDiafragma.SetActive(false);
        CenaCamisinha.SetActive(false);
        CenaPilulaDiaSeguinte.SetActive(true);
        CenaPilulaAnticoncepcional1.SetActive(false);
        CenaPilulaAnticoncepcional2.SetActive(false);
        CenaDIU.SetActive(false);
        CenaInjecaoAnticoncepcional1.SetActive(false);
        CenaInjecaoAnticoncepcional2.SetActive(false);
        CenaCamisinhaFeminina.SetActive(false);
        CenaDiafragma.SetActive(false);
        CenaVideoDIU1.SetActive(false);
        VideoCamisinhaFeminina1.SetActive(false);
        VideoDiafragma1.SetActive(false);
    }

    public void IrCenaPilulaAntiConcepcional1()
    {
        Cena1.SetActive(false);
        Cena2.SetActive(false);
        CenaFinal.SetActive(false);
        Opcoes.SetActive(false);
        Fundo.SetActive(true);
        Sala.SetActive(false);
        VideoDIU.SetActive(false);
        VideoCamisinhaFeminina.SetActive(false);
        VideoDiafragma.SetActive(false);
        CenaCamisinha.SetActive(false);
        CenaPilulaDiaSeguinte.SetActive(false);
        CenaPilulaAnticoncepcional1.SetActive(true);
        CenaPilulaAnticoncepcional2.SetActive(false);
        CenaDIU.SetActive(false);
        CenaInjecaoAnticoncepcional1.SetActive(false);
        CenaInjecaoAnticoncepcional2.SetActive(false);
        CenaCamisinhaFeminina.SetActive(false);
        CenaDiafragma.SetActive(false);
        CenaVideoDIU1.SetActive(false);
        VideoCamisinhaFeminina1.SetActive(false);
        VideoDiafragma1.SetActive(false);
    }

    public void IrCenaPilulaAntiConcepcional2()
    {
        Cena1.SetActive(false);
        Cena2.SetActive(false);
        CenaFinal.SetActive(false);
        Opcoes.SetActive(false);
        Fundo.SetActive(true);
        Sala.SetActive(false);
        VideoDIU.SetActive(false);
        VideoCamisinhaFeminina.SetActive(false);
        VideoDiafragma.SetActive(false);
        CenaCamisinha.SetActive(false);
        CenaPilulaDiaSeguinte.SetActive(false);
        CenaPilulaAnticoncepcional1.SetActive(false);
        CenaPilulaAnticoncepcional2.SetActive(true);
        CenaDIU.SetActive(false);
        CenaInjecaoAnticoncepcional1.SetActive(false);
        CenaInjecaoAnticoncepcional2.SetActive(false);
        CenaCamisinhaFeminina.SetActive(false);
        CenaDiafragma.SetActive(false);
        CenaVideoDIU1.SetActive(false);
        VideoCamisinhaFeminina1.SetActive(false);
        VideoDiafragma1.SetActive(false);
    }

    public void IrCenaDIU()
    {
        Cena1.SetActive(false);
        Cena2.SetActive(false);
        CenaFinal.SetActive(false);
        Opcoes.SetActive(false);
        Fundo.SetActive(true);
        Sala.SetActive(false);
        VideoDIU.SetActive(true);
        VideoCamisinhaFeminina.SetActive(false);
        VideoDiafragma.SetActive(false);
        CenaCamisinha.SetActive(false);
        CenaPilulaDiaSeguinte.SetActive(false);
        CenaPilulaAnticoncepcional1.SetActive(false);
        CenaPilulaAnticoncepcional2.SetActive(false);
        CenaDIU.SetActive(true);
        CenaInjecaoAnticoncepcional1.SetActive(false);
        CenaInjecaoAnticoncepcional2.SetActive(false);
        CenaCamisinhaFeminina.SetActive(false);
        CenaDiafragma.SetActive(false);
        CenaVideoDIU1.SetActive(true);
        VideoCamisinhaFeminina1.SetActive(false);
        VideoDiafragma1.SetActive(false);
    }

    public void IrCenaInjecaoAnticoncepcional1()
    {
        Cena1.SetActive(false);
        Cena2.SetActive(false);
        CenaFinal.SetActive(false);
        Opcoes.SetActive(false);
        Fundo.SetActive(true);
        Sala.SetActive(false);
        VideoDIU.SetActive(false);
        VideoCamisinhaFeminina.SetActive(false);
        VideoDiafragma.SetActive(false);
        CenaCamisinha.SetActive(false);
        CenaPilulaDiaSeguinte.SetActive(false);
        CenaPilulaAnticoncepcional1.SetActive(false);
        CenaPilulaAnticoncepcional2.SetActive(false);
        CenaDIU.SetActive(false);
        CenaInjecaoAnticoncepcional1.SetActive(true);
        CenaInjecaoAnticoncepcional2.SetActive(false);
        CenaCamisinhaFeminina.SetActive(false);
        CenaDiafragma.SetActive(false);
        CenaVideoDIU1.SetActive(false);
        VideoCamisinhaFeminina1.SetActive(false);
        VideoDiafragma1.SetActive(false);
    }

    public void IrCenaInjecaoAnticoncepcional2()
    {
        Cena1.SetActive(false);
        Cena2.SetActive(false);
        CenaFinal.SetActive(false);
        Opcoes.SetActive(false);
        Fundo.SetActive(true);
        Sala.SetActive(false);
        VideoDIU.SetActive(false);
        VideoCamisinhaFeminina.SetActive(false);
        VideoDiafragma.SetActive(false);
        CenaCamisinha.SetActive(false);
        CenaPilulaDiaSeguinte.SetActive(false);
        CenaPilulaAnticoncepcional1.SetActive(false);
        CenaPilulaAnticoncepcional2.SetActive(false);
        CenaDIU.SetActive(false);
        CenaInjecaoAnticoncepcional1.SetActive(false);
        CenaInjecaoAnticoncepcional2.SetActive(true);
        CenaCamisinhaFeminina.SetActive(false);
        CenaDiafragma.SetActive(false);
        CenaVideoDIU1.SetActive(false);
        VideoCamisinhaFeminina1.SetActive(false);
        VideoDiafragma1.SetActive(false);
    }

    public void IrCenaCamisinhaFeminino()
    {
        Cena1.SetActive(false);
        Cena2.SetActive(false);
        CenaFinal.SetActive(false);
        Opcoes.SetActive(false);
        Fundo.SetActive(true);
        Sala.SetActive(false);
        VideoDIU.SetActive(false);
        VideoCamisinhaFeminina.SetActive(true);
        VideoDiafragma.SetActive(false);
        CenaCamisinha.SetActive(false);
        CenaPilulaDiaSeguinte.SetActive(false);
        CenaPilulaAnticoncepcional1.SetActive(false);
        CenaPilulaAnticoncepcional2.SetActive(false);
        CenaDIU.SetActive(false);
        CenaInjecaoAnticoncepcional1.SetActive(false);
        CenaInjecaoAnticoncepcional2.SetActive(false);
        CenaCamisinhaFeminina.SetActive(true);
        CenaDiafragma.SetActive(false);
        CenaVideoDIU1.SetActive(false);
        VideoCamisinhaFeminina1.SetActive(true);
        VideoDiafragma1.SetActive(false);
    }

    public void IrCenaDiafragma()
    {
        Cena1.SetActive(false);
        Cena2.SetActive(false);
        CenaFinal.SetActive(false);
        Opcoes.SetActive(false);
        Fundo.SetActive(true);
        Sala.SetActive(false);
        VideoDIU.SetActive(false);
        VideoCamisinhaFeminina.SetActive(false);
        VideoDiafragma.SetActive(true);
        CenaCamisinha.SetActive(false);
        CenaPilulaDiaSeguinte.SetActive(false);
        CenaPilulaAnticoncepcional1.SetActive(false);
        CenaPilulaAnticoncepcional2.SetActive(false);
        CenaDIU.SetActive(false);
        CenaInjecaoAnticoncepcional1.SetActive(false);
        CenaInjecaoAnticoncepcional2.SetActive(false);
        CenaCamisinhaFeminina.SetActive(false);
        CenaDiafragma.SetActive(true);
        CenaVideoDIU1.SetActive(false);
        VideoCamisinhaFeminina1.SetActive(false);
        VideoDiafragma1.SetActive(true);
    }
}
