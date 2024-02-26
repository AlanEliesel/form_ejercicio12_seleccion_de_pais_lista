using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_ejercicio12_seleccion_de_pais_lista
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            cbo_paises.Items.Add("AFGANISTÁN");
            cbo_paises.Items.Add("DINAMARCA");
            cbo_paises.Items.Add("EGIPTO");
            cbo_paises.Items.Add("EMIRATOS ÁRABES UNIDOS");
            cbo_paises.Items.Add("FILIPINAS");
            cbo_paises.Items.Add("HONDURAS");
            cbo_paises.Items.Add("FRANCIA");
        }

        private void cbo_paises_SelectedIndexChanged(object sender, EventArgs e)
        {

            int indice = cbo_paises.SelectedIndex;


            switch (indice)
            {

                case 0:
                    {
                        string informacion = "Afganistán, oficialmente República Islámica de Afganistán, es un país sin salida al mar situado en el corazón de Asia. Comparte sus fronteras con Pakistán al sur y al este, Irán al oeste, Turkmenistán, Uzbekistán y Tayikistán al norte, y la República Popular China al noreste a través del Corredor Wakhan.";

                        txt_informacion.Text = informacion;

                        break;
                    }

                case 1:
                    {
                        string informacion = "Dinamarca, oficialmente conocida como el Reino de Dinamarca, es un país situado en el norte de Europa. A continuación, se proporciona información relevante sobre diversos aspectos de Dinamarca, incluyendo su gobierno, recursos naturales, economía, y otros datos de interés.";

                        txt_informacion.Text = informacion;

                        break;
                    }
                case 2:
                    {
                        string informacion = "Egipto es un país transcontinental ubicado en el norte de África y Oriente Medio. Es conocida por su rica historia, con una civilización que prosperó durante miles de años. El país es famoso por sus antiguos avances culturales en diversas áreas del conocimiento humano, incluidas las artes, la ciencia, la tecnología y la religión. Egipto también es famoso por sus grandes monumentos, tumbas, templos y obras de arte, que reflejan la profundidad y grandeza de su cultura. La antigua civilización egipcia se asentó en el valle del Nilo y el río Nilo jugó un papel importante en la historia y la economía del país.";

                        txt_informacion.Text = informacion;

                        break;
                    }

                case 3:
                    {
                        string informacion = "Los Emiratos Árabes Unidos (EAU) es un país ubicado en Asia Occidental, con una población aproximada de 9.558 millones de personas, de las cuales el 93,91% son inmigrantes, lo que lo convierte en el país con mayor porcentaje de inmigrantes en el mundo. La capital de los Emiratos Árabes Unidos es Abu Dhabi y su moneda es el dirham. El país tiene una densidad de población moderada de 97 habitantes por kilómetro cuadrado. Los Emiratos Árabes Unidos son conocidos por ser la 29ª economía por volumen de PIB, con una deuda pública de 125.885 millones de euros (148.988 millones de dólares) en 2021, lo que representa el 35,9% del PIB. La deuda per cápita es de 13.171 euros o 15.588 dólares por habitante.";

                        txt_informacion.Text = informacion;

                        break;
                    }

                case 4:
                    {
                        string informacion = "La República de Filipinas, también conocida como Islas Filipinas o simplemente Filipinas, es un país insular del sudeste asiático. Se encuentra en el Cinturón de Fuego del Pacífico y consta de 7.107 islas divididas en tres regiones principales: Luzón, Visayas y Mindanao. El país está situado en el sudeste asiático, limita con el estrecho de Luzón al norte, el mar de China Meridional y Vietnam al oeste, Borneo al suroeste, el mar de Célebes al sur y el mar de Filipinas al este.";

                        txt_informacion.Text = informacion;

                        break;
                    }

                case 5:
                    {
                        string informacion = "Honduras es un país ubicado en Centroamérica, que limita con Guatemala, Nicaragua y El Salvador. Tiene una vasta franja de costa a lo largo del Mar Caribe al norte y una franja más pequeña a lo largo del Océano Pacífico al sur. La capital de Honduras es Tegucigalpa y el idioma oficial es el español. La población estimada a partir de 2023 es de alrededor de 9.744.000. El país está organizado en 18 departamentos y un Distrito Central, siendo Tegucigalpa y Comayagela las capitales. Honduras es conocida por sus recursos naturales, incluidos sus bosques tropicales y su diversa vida silvestre, como insectos coloridos, reptiles y animales más grandes como venados, ocelotes y pumas.";

                        txt_informacion.Text = informacion;

                        break;
                    }

                case 6:
                    {
                        string informacion = "Francia, oficialmente conocida como República Francesa, es un país ubicado en Europa Occidental. Es miembro de la Unión Europea y tiene una población de aproximadamente 66,9 millones de personas en enero de 2017. El país tiene una superficie total de 545.630 km2 y es conocido por sus diversos paisajes, incluidas llanuras y colinas. La capital de Francia es París, que es una de las ciudades más visitadas del mundo. El país también es reconocido por su producción de vinos, su rica cultura e historia, lo que lo convierte en un destino turístico popular.";

                        txt_informacion.Text = informacion;

                        break;
                    }
            }

        }


        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txt_informacion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
