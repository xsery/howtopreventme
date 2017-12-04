using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ButtonInterrogacao : MonoBehaviour {

    private bool condicao;
    public bool terminou;
    public GameObject objeto;
    
    public Text balao;
    public Text tema;
    public Text pop;
    public int contFala;

    // Use this for initialization
    void Start () {
        condicao = false;
        terminou = false;
        contFala = -1;
    }
	
	// Update is called once per frame
	void Update () {
        objeto.SetActive(condicao);
	}

    public void mudar()
    {
        condicao = !condicao;
    }

    public void trocaDeFala()
    {
        contNemFala();
        if (contFala == 0)
        {
            balao.text = "AJUDA\nOs testículos\nsão duas\nglândulas de\nforma oval\nque estão\nsituadas na\nbolsa escrotal.";
            tema.text = "Clique no TESTÍCULO";
            pop.text = "São dois testículos. Produz o hormônio\nsexual masculino (testosterona) e produz\nos espermatozóides. Próximo...";
        }
        if (contFala == 1)
        {
            balao.text = "AJUDA\nOs epidídimos\nsão canais\nalongados\nque se\nenrolam e\nrecobrem\nposterior-\nmente a\n" +
                "superfície\nde cada\ntestículo.";
            tema.text = "Clique no EPIDÍDIMO";
            GameManager.Instance.ganhaUmPonto();
            pop.text = "Corresponde ao local onde os\nespermatozoides, produzidos no\ntestículo, são armazenados. Próximo...";
        }
        if (contFala == 2)
        {
            balao.text = "AJUDA\nO canal\ndeferente é um\ntubo fino e longo\nque sai de cada\nepidídimo.\nO conjunto dos\n" +
                "espermatozoides,\ndo líquido\nseminal e do\nlíquido\nprostático,\nconstitui o\n'esperma' ou\n'sêmen'.";
            tema.text = "Clique no CANAL\nDEFERENTE";
            GameManager.Instance.ganhaUmPonto();
            pop.text = "São dois tubos que partem dos testículos,\nrecebem o líquido seminal da vesícula seminal," +
                "\npassa pela próstata e termina na uretra.\nPróximo...";
        }
        if (contFala == 3)
        {
            balao.text = "AJUDA\nA vesícula\nseminal é\nformada por\nduas\npequenas\nbolsas\nlocalizadas\natrás da\nbexiga. Sua\n" +
                "função é\nproduzir o\n'líquido\nseminal'.";
            tema.text = "Clique na VESÍCULA\nSEMINAL";
            GameManager.Instance.ganhaUmPonto();
            pop.text = "O líquido seminal também ajuda a\nneutralizar a acidez da vagina, evitando\n" +
                "que os espermatozoides morram no\ncaminho até os óvulos. Próximo...";
        }
        if (contFala == 4)
        {
            balao.text = "AJUDA\nA próstata é\numa grândula,\nlocalizada\nabaixo da\nbexiga.";
            tema.text = "Clique na PRÓSTATA";
            GameManager.Instance.ganhaUmPonto();
            pop.text = "Produz o 'líquido prostático', uma\nsecreção clara e fluida que integra a\n"+
                "composição do esperma. Próximo...";
        }
        if (contFala == 5)
        {
            balao.text = "AJUDA\nComeça na\nbexiga,\natravessa a\npróstata e o\npênis até a\nponta da\nglande, onde\nhá uma\n" +
                "abertura pela\nqual são\neliminados o\nsêmen e a\nurina.";
            tema.text = "Clique no URETRA";
            GameManager.Instance.ganhaUmPonto();
            pop.text = "A uretra é um canal que, nos homens,\nserve ao sistema urinário e ao sistema\nreprodutor. Próximo...";
        }
        if (contFala == 6)
        {
            balao.text = "AJUDA\nO pênis é um\nórgão cilíndrico\nexterno.";
            tema.text = "Clique no PÊNIS";
            GameManager.Instance.ganhaUmPonto();
            pop.text = "Através do pênis são eliminados a urina (função\nexcretora) e o sêmen (função reprodutora). A" +
                "\nsua 'ponta' é chamada de 'glande'. Próximo...";
        }
        
    }

    public void contNemFala()
    {
        if (contFala >= 6)
        {
            GameManager.Instance.ganhaUmPonto();
            terminou = true;
            contFala = 0;
        }
        else
        {
            contFala++;
        }
    }
}
