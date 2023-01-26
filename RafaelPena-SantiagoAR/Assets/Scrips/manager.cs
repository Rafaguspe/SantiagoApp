using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;



public class manager : MonoBehaviour
{
	public GameObject Holder,PaginaLugares,ResenaVista,LugarImg,Acerca,DescripcionGO,Galeria,GOMapaBtn,Lugares
		,CatAreas,InicioBtn,BGPaginaLugares,btnResena;
		
	public GameObject [] RellenoEstrellas;	
		
	public Button Lugar1,Lugar2,Lugar3,Lugar4,Lugar5,Lugar6,LugarCat1,LugarCat2,categoria1,
		categoria2,categoria3,butonAtras,butonAtras2,butonUbicacion,Pzoom,peqZoom1,peqZoom2,peqZoom3,BtnHistoria,
		BtnEntretenimiento,BtnGastronomia,btnInicio,resenaBtn,Publicar;
	
	public Button [] estrellas;
		
	public Sprite [] lugar1Img,lugar2Img,lugar3Img,lugar4Img,lugar5Img,lugar6Img;
	
	public Image Hgaleria1,Hgaleria2,Hgaleria3,ImgLugar1,ImgLugarResena,ZoomGrande,Zoompeq1,Zoompeq2,Zoompeq3,Landcat1,Landcat2;
	public TMP_Text Descripcion,NombreLugar,Titulo,InfoCat1,InfoCat2,Bienvenidotxt,Nombretxt,NombreLugarResenatxt,Calificaciontxt,Caliprincipaltxt;
	public string ruta,ruta1,ruta2,ruta3,ruta4;
	public int num1,num2,caso;
	public int [] califica;
	
	// Start is called on the frame when a script is enabled just before any of the Update methods is called the first time.
	protected void Start()
	{
		// Encendido y apagado de componentes
		
		
		for (int i = 0; i < 5; i++) {
			RellenoEstrellas [i].SetActive(false);
		}
		Publicar.interactable = false;
		BtnEntretenimiento.interactable = true;
		BtnHistoria.interactable = true;
		BtnGastronomia.interactable=true;
		estrellas[0].onClick.AddListener(()=>Estrellas(0,caso));
		estrellas[1].onClick.AddListener(()=>Estrellas(1,caso));
		estrellas[2].onClick.AddListener(()=>Estrellas(2,caso));
		estrellas[3].onClick.AddListener(()=>Estrellas(3,caso));
		estrellas[4].onClick.AddListener(()=>Estrellas(4,caso));
		
		PaginaLugares.SetActive(false);
		ResenaVista.SetActive(false);
		CatAreas.SetActive(false);
		InicioBtn.SetActive(false);
		Bienvenidotxt.text="Bienvenido";
		Nombretxt.text="Rafael Peña";
		Titulo.text="Lugares Populares";
		Lugares.SetActive(true);
		//Declarar variable imagen sea igual al componente imagen de pagina lugares
		ZoomGrande= BGPaginaLugares.GetComponent<Image>();
		
		//acciones de los botones
		butonAtras.onClick.AddListener(backfn);
		butonUbicacion.onClick.AddListener(()=> UbicacionMap(ruta));
		Lugar1.onClick.AddListener(()=> lugarfn(1));
		Lugar2.onClick.AddListener(()=> lugarfn(2));
		Lugar3.onClick.AddListener(()=> lugarfn(3));
		Lugar4.onClick.AddListener(()=> lugarfn(4));
		Lugar5.onClick.AddListener(()=> lugarfn(5));
		Lugar6.onClick.AddListener(()=> lugarfn(6));
		LugarCat1.onClick.AddListener(()=> lugarfn(num1));
		LugarCat2.onClick.AddListener(()=> lugarfn(num2));
		btnInicio.onClick.AddListener(()=> Start());
		
		//Accion de los botones para la categoria 
		BtnHistoria.onClick.AddListener(()=> Categoria(1));
		BtnEntretenimiento.onClick.AddListener(()=> Categoria(2));
		BtnGastronomia.onClick.AddListener(()=> Categoria(3));
		
		
		categoria1.onClick.AddListener(()=> zoomCat("UI/Historia 1"));
		categoria2.onClick.AddListener(()=> zoomCat("UI/Entretenimiento"));
		categoria3.onClick.AddListener(()=> zoomCat("UI/Gastro"));
		
		
		//Accion de los botones para el zoom
		Pzoom.onClick.AddListener(()=> zoom(caso,ruta1));
		peqZoom1.onClick.AddListener(()=> zoom(caso,ruta2));
		peqZoom2.onClick.AddListener(()=> zoom(caso,ruta3));
		peqZoom3.onClick.AddListener(()=> zoom(caso,ruta4));
		
		
		resenaBtn.onClick.AddListener(()=>Resena(caso));
		
	}
   
	// funcion para mostrar los lugares
	
	void lugarfn(int lugar)
	{
		//butonAtras.onClick.AddListener(backfn);
		butonAtras.onClick.AddListener(()=>Start());
		ZoomGrande.sprite= Resources.Load<Sprite>("none");
		PaginaLugares.SetActive(true);
		LugarImg.SetActive(true);
		Acerca.SetActive(true);
		DescripcionGO.SetActive(true);
		Galeria.SetActive(true);
		GOMapaBtn.SetActive(true);
		btnResena.SetActive(true);
		
		switch (lugar)
		{
		case 1: 
			Calificaciontxt.text=califica[0].ToString();
			Caliprincipaltxt.text=califica[0].ToString();	
			NombreLugar.text="Monumento de la Restauracion";
			Descripcion.text="El Monumento a los Héroes de la Restauración conocido también como el Monumento de Santiago"+ 
				" está erigido en la ciudad de Santiago de los Caballeros para conmemorar el 100 aniversario de la independencia del país."+
				"Originalmente fue nombrado como el Monumento de la Paz de Trujillo y el mismo sería parte de una serie de obras de distintas"+
				" índoles construidas en Santiago de los Caballeros en la misma época. Su construcción inició y finalizó en 1944, pero no sería"+
				" hasta 1953 por voluntad del entonces vicepresidente Joaquín Balaguer que sería inaugurado.";
			ImgLugar1.sprite= lugar1Img[3];
			Hgaleria1.sprite= lugar1Img[0];
			Hgaleria2.sprite= lugar1Img[1];
			Hgaleria3.sprite= lugar1Img[2];
			caso=lugar;
			ruta1="UI/monumento";
			ruta2="UI/monumento/m1";
			ruta3="UI/monumento/m2";
			ruta4="UI/monumento/m3";
			ruta="https://goo.gl/maps/HPFSuYzLgLzmmZ5P8";
			break;
		
		
		case 2: 
			Calificaciontxt.text=califica[1].ToString();
			Caliprincipaltxt.text=califica[1].ToString();
			NombreLugar.text="Fortaleza San Luis";
			Descripcion.text="Construida a principios del siglo XIX, esta fortaleza de tonos amarillos tiene "+
				"una hermosa y ornamentada puerta exterior con dos cañones que dan a la ciudad. Un puesto de"+
				" defensa clave durante la Guerra de La Restauración, los marines de EE.UU. también usaron este "+
				"fuerte como base durante la primera ocupación estadounidense en República Dominicana (1916-1924)."+
				"Dentro del complejo encontrarás múltiples cañones y tanques del ejército en exhibición, así como las "+
				"estatuas de los héroes de la independencia dominicana y otras figuras históricas importantes."+
				"La fortaleza sirvió como prisión en años posteriores. En 2005, abrió sus puertas un pequeño "+
				"museo que exhibe numerosos artefactos y objetos culturales taínos, así como pinturas, espadas de "+
				"la época y fotografías de la ocupación estadounidense.";
			ImgLugar1.sprite= lugar2Img[3];
			Hgaleria1.sprite= lugar2Img[0];
			Hgaleria2.sprite= lugar2Img[1];
			Hgaleria3.sprite= lugar2Img[2];
			caso=lugar;
			ruta1="UI/Fortaleza San Luis";
			ruta2="UI/San Luis/SanLuis1";
			ruta3="UI/San Luis/SanLuis2";
			ruta4="UI/San Luis/SanLuis3";
			ruta="https://goo.gl/maps/ihQonFfuZxnkQ3Li9";
			
		
			break;
			
			
		case 3: 
			Calificaciontxt.text=califica[2].ToString();
			Caliprincipaltxt.text=califica[2].ToString();
			NombreLugar.text="Parque Central";
			Descripcion.text="Es el primer espacio urbano disponible para la población. Está dirigido por un patronato que preside la "+
				"Asociación Para el Desarrollo de Santiago (APEDI).En su interior tiene espacios para las actividades deportivas, recreativas,"+
				" culturales, sociales y artísticas; así como para feria y muestras comerciales.";
			ImgLugar1.sprite= lugar3Img[3];
			Hgaleria1.sprite= lugar3Img[0];
			Hgaleria2.sprite= lugar3Img[1];
			Hgaleria3.sprite= lugar3Img[2];
			caso=lugar;
			ruta1="UI/parque central";
			ruta2="UI/parque/Parque1";
			ruta3="UI/parque/Parque2";
			ruta4="UI/parque/Parque3";
			ruta="https://goo.gl/maps/DXqB5RQ8hKfcw9iR9";
			
			break;
			
			
			
		case 4: 
			Calificaciontxt.text=califica[3].ToString();
			Caliprincipaltxt.text=califica[3].ToString();
			NombreLugar.text="square one";
			Descripcion.text="Square One es el restaurante donde siempre encontrarás la mayor variedad de comida, un servicio"+
				" rápido y de calidad.La elección de los componentes para nuestros platos es altamente supervisada bajo "+
				"lo más altos estándares. Nos encargamos de asegurar siempre un uso de ingredientes frescos y de calidad.";
			ImgLugar1.sprite= lugar4Img[3];
			Hgaleria1.sprite= lugar4Img[0];
			Hgaleria2.sprite= lugar4Img[1];
			Hgaleria3.sprite= lugar4Img[2];
			caso=lugar;
			ruta1="UI/Square One";
			ruta2="UI/SquareOne/SO1";
			ruta3="UI/SquareOne/SO2";
			ruta4="UI/SquareOne/SO3";
			ruta="https://goo.gl/maps/PZo4vN89bDhJQYVS6";
			
			break;
			
			
		case 5: 
			Calificaciontxt.text=califica[4].ToString();
			Caliprincipaltxt.text=califica[4].ToString();
			NombreLugar.text="Foodtropolis";
			Descripcion.text="Foodtropolis es el lugar indicado para los amantes de la comida, este es un espacio dedicado a la venta"+
				" de comida rapida en diversos negocio establecidos en un mismo lugar. Buscamos siempre tener la mejor diversion y ser el"+
				" mejor lugar para pasar buenos momentos entre amigos y familiares.";
			ImgLugar1.sprite= lugar5Img[3];
			Hgaleria1.sprite= lugar5Img[0];
			Hgaleria2.sprite= lugar5Img[1];
			Hgaleria3.sprite= lugar5Img[2];
			caso=lugar;
			ruta1="UI/foodTropolis";
			ruta2="UI/foodTropolis/Food1";
			ruta3="UI/foodTropolis/Food2";
			ruta4="UI/foodTropolis/Food3";
			ruta="https://goo.gl/maps/syjNeTVkShxvbWU88";
			
		
			break;
			
			
			
		case 6: 
			Calificaciontxt.text=califica[5].ToString();
			Caliprincipaltxt.text=califica[5].ToString();
			NombreLugar.text="Estadio Cibao";
			Descripcion.text="El Estadio Cibao es un estadio de béisbol en Santiago de los Caballeros, República Dominicana. Se utiliza para"+
				" los juegos de béisbol teniendo de anfitriones a las Águilas Cibaeñas, equipo perteneciente a la Liga Dominicana de Béisbol. El estadio"+
				" se inauguró el 25 de octubre de 1958.Se le conoce como “El valle de la muerte”, debido a la impresionante efectividad del equipo Águilas"+
					" Cibaeñas en su terreno de juego.2​ Las Águilas Cibaeñas siempre tienen mejor récord en casa que en la ruta, en el Estadio Cibao históricamente"+
					" han sido más dominantes que cualquier equipo.";
			ImgLugar1.sprite= lugar6Img[3];
			Hgaleria1.sprite= lugar6Img[0];
			Hgaleria2.sprite= lugar6Img[1];
			Hgaleria3.sprite= lugar6Img[2];
			caso=lugar;
			ruta1="UI/Estadio-Cibao-1";
			ruta2="UI/Estadio/estadio1";
			ruta3="UI/Estadio/estadio2";
			ruta4="UI/Estadio/estadio3";
			ruta="https://goo.gl/maps/15SwkwnAh2wqHgJ98";
			
			break;
			
		}// fin switch
		
		
	}// fin lugarfn
	
   
	//Metodo para abrir en google maps
	void UbicacionMap(string ruta)
	{
		
		Application.OpenURL(ruta);
			
	
	}// fin metodo UbicacionMap
   
   
   
	// metodo para volver atras
	void backfn(){
		PaginaLugares.SetActive(false);
		
	}//fin backfn
	
	
	void backfn2(int caso){
		PaginaLugares.SetActive(true);
		ResenaVista.SetActive(false);
		lugarfn(caso);
		
	}//fin backfn
	
	
	
	
	// Metodo para Aumentar la imagen
	void zoom(int zm,string rutaimg){
		
		butonAtras.onClick.AddListener(()=> lugarfn(zm));
			ZoomGrande.sprite= Resources.Load<Sprite>(rutaimg);
			LugarImg.SetActive(false);
			Acerca.SetActive(false);
				DescripcionGO.SetActive(false);
			Galeria.SetActive(false);
		GOMapaBtn.SetActive(false);
		btnResena.SetActive(false);
		
		
	}// fin zoom
	
	void zoomCat(string rutaimg){
		PaginaLugares.SetActive(true);
		butonAtras.onClick.AddListener(()=> backfn());
		ZoomGrande.sprite= Resources.Load<Sprite>(rutaimg);
		LugarImg.SetActive(false);
		Acerca.SetActive(false);
		DescripcionGO.SetActive(false);
		Galeria.SetActive(false);
		GOMapaBtn.SetActive(false);
		btnResena.SetActive(false);
		
		
	}// fin zoom
   
   
	void Categoria(int cat){
		InicioBtn.SetActive(true);
		Lugares.SetActive(false);
		CatAreas.SetActive(true);
		
		switch (cat)
		{
		
			//Categoria Historia
		case 1:
			BtnEntretenimiento.interactable = false;
			BtnGastronomia.interactable = false;
			Bienvenidotxt.text="";
			Nombretxt.text="";
			Titulo.text="Lugares históricos";
			Landcat1.sprite= Resources.Load<Sprite>("UI/monumento");
			Landcat2.sprite= Resources.Load<Sprite>("UI/Fortaleza San Luis");
			InfoCat1.text="Monumento de la Restauracion";
			InfoCat2.text="Fortaleza San Luis";
			num1=1;
			num2=2;
		
			break;
			
			//lugares de Entretenimiento
			
		case 2:
			BtnHistoria.interactable = false;
			BtnGastronomia.interactable = false;
			Bienvenidotxt.text="";
			Nombretxt.text="";
			Titulo.text="Lugares de entretenimiento";
			Landcat1.sprite= Resources.Load<Sprite>("UI/parque central");
			Landcat2.sprite= Resources.Load<Sprite>("UI/Estadio-Cibao-1");
			InfoCat1.text="Parque Central";
			InfoCat2.text="Estadio Cibao";
			num1=3;
			num2=6;
		
			break;
			
			
			//lugares de Gastronomicos
			
		case 3:
			BtnEntretenimiento.interactable = false;
			BtnHistoria.interactable = false;
			Bienvenidotxt.text="";
			Nombretxt.text="";
			Titulo.text="Lugares gastronómicos";
			Landcat1.sprite= Resources.Load<Sprite>("UI/Square One");
			Landcat2.sprite= Resources.Load<Sprite>("UI/foodTropolis");
			InfoCat1.text="Square One";
			InfoCat2.text="FoodTropolis";
			num1=4;
			num2=5;
		
			break;	
			
			
		}//fin switch de categoria
		
	}// fin categoria
   
   
	void Resena(int resena){
		ResenaVista.SetActive(true);
		butonAtras2.onClick.AddListener(()=>backfn2(resena));
		caso=resena;
		switch (resena)
		{
		
		case 1:
			NombreLugarResenatxt.text="Monumento de la Restauracion";
			ImgLugarResena.sprite= lugar1Img[3];					
			break;
			
		case 2:
			NombreLugarResenatxt.text="Fortaleza San Luis";
			ImgLugarResena.sprite= lugar2Img[3];
			break;	
		
		case 3:
			NombreLugarResenatxt.text="Parque Central";
			ImgLugarResena.sprite= lugar3Img[3];
			break;	
			
		case 4:
			NombreLugarResenatxt.text="square one";
			ImgLugarResena.sprite= lugar4Img[3];
			break;
			
		case 5:
			NombreLugarResenatxt.text="Foodtropolis";
			ImgLugarResena.sprite= lugar5Img[3];
			break;
			
		case 6:
			NombreLugarResenatxt.text="Estadio Cibao";
			ImgLugarResena.sprite= lugar6Img[3];
			break;
			
		}//fin switch resena
		
		
		
		
		
	}//fin resena
   
   
	void Estrellas (int estrella,int caso){
		
		for (int i = 0; i < 5; i++) {
			RellenoEstrellas[i].SetActive(false);
		}
		
		
		for (int j = 0; j <= estrella; j++) {
			RellenoEstrellas[j].SetActive(true);
		}
		
		
		Publicar.interactable = true;
		Publicar.onClick.AddListener(()=>Publi(estrella));
		
		
	}//fin estrella
   
   
	void Publi (int estrella)
	{
		califica[caso-1]=estrella+1;
		lugarfn(caso);
		ResenaVista.SetActive(false);
	}
   
   
   
   
   
   
   
   
}// fin public
