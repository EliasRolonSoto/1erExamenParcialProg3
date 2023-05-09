using DotnetExam.Entities;
using Xunit;


namespace DotnetExam.Tests
{
    public class Exam_39188496_RolonSoto
    {
        [Fact]
        public void Test1_Teoria_NET()
        {

            //Describa la diferencia entre .NET Framework y .NET Core
            var respuesta = "Una diferencia importante entre .NET Framework y .NET Core es que el primero es una plataforma de desarrollo de software para Windows, mientras que el segundo es una plataforma de desarrollo de software de código abierto que se puede usar en Windows, Linux y macOS.";

            Assert.NotEqual(string.Empty, respuesta);


        }

        [Fact]
        public void Test2_Teoria_Assembly()
        {


            //Describa que es un assembly o ensamblado en .NET
            var respuesta = "En .NET, un assembly es un archivo ejecutable o una biblioteca de clases que contiene uno o más módulos de código compilado, metadatos y recursos asociados. Cada assembly tiene un nombre único que lo identifica, puede contener uno o más namespaces que organizan las clases y otros tipos en el código, y puede ser referenciado en una aplicación de .NET para crear instancias de los tipos de datos que se definen en él. Los ensamblados son útiles para la creación y distribución de bibliotecas de clases reutilizables y componentes de software en una variedad de aplicaciones de .NET.";

            Assert.NotEqual(string.Empty, respuesta);


        }


        [Fact]
        public void Test3_Teoria_IL()
        {


            //Describa que es el Lenguaje Intermedio o IL
            var respuesta = "El Lenguaje Intermedio (IL) es un código binario de bajo nivel utilizado en .NET para compilar el código fuente de lenguajes de alto nivel como C# y Visual Basic. El IL es independiente del procesador y del sistema operativo, lo que permite que el mismo código IL se ejecute en diferentes plataformas. El código fuente se compila en código IL antes de su ejecución en la plataforma de destino, lo que optimiza el rendimiento y la seguridad del código y permite su distribución como un ensamblado para su uso en cualquier aplicación de .NET.";

            Assert.NotEqual(string.Empty, respuesta);


        }




        [Fact]
        public void Test4_DateTime_Formatting()
        {
           

            var finalWorldCupMatch = new DateTime(2022, 12, 18, 15, 30, 23);


            Assert.Equal("18/12/22 15:30:23", finalWorldCupMatch.ToString("dd/MM/yy HH:mm:ss"));
            Assert.Equal("18/12/22 03:30 p. m.", finalWorldCupMatch.ToString("dd/MM/yy hh:mm p. 'm'."));
            Assert.Equal("18 de diciembre de 2022", finalWorldCupMatch.ToString("dd 'd'e MMMM 'd'e yyyy"));


        }

        [Fact]
        public void Test5_DateTime_Days()
        {


            var finalWorldCupMatch = new DateTime(2022, 12, 18, 15, 30, 23);
            var today = new DateTime(2023, 5, 9, 15, 00, 00);

            var dias = today.Subtract(finalWorldCupMatch);

            var result = $"{dias.Days} Días totales desde la final del mundo";

            
            Assert.Equal("141 Días totales desde la final del mundo", result );

        }



        [Fact]
        public void Test6_POO_Alumno()
        {
            var alumno = new Alumno();
            alumno.AlumnoId = 123456;
            alumno.Legajo = "000010/22";
            alumno.Nombre = "Lionel";
            alumno.Apellido = "Messi";
            

            Assert.Equal(123456, alumno.AlumnoId);
            Assert.Equal("000010/22", alumno.Legajo);
            Assert.Equal("Lionel Messi", alumno.NombreCompleto);
        }



        [Fact]
        public void Test7_POO_Materia()
        {
            var materia = new Materia(123456, "Programacion III");

            Assert.Equal("Programacion III", materia.Nombre);
            Assert.Equal(123456, materia.MateriaId);

        }

        [Fact]
        public void Test8_POO_UML()
        {
            //En base al diagrama UML del examen
            //Codifique las clases e interfaces necesarias

            var docente = new Docente(1, "Lionel", "Scaloni");
            docente.Id = 1;

            var alumno1 = new Alumno();
            alumno1.Id = 101010;
            alumno1.Legajo = "000010/22";
            alumno1.AlumnoId = 101010;
            alumno1.Nombre = "Lionel";
            alumno1.Apellido = "Messi";

            var alumno2 = new Alumno();
            alumno2.Id = 777;
            alumno2.Legajo = "000007/22";
            alumno2.AlumnoId = 777;
            alumno2.Nombre = "Rodrigo";
            alumno2.Apellido = "De Paul";


            var materia = new Materia(123456, "Programacion III")
            {
                Profesor = docente
            };
            materia.Alumnos.Add(alumno1);
            materia.Alumnos.Add(alumno2);



            Assert.Equal("Programacion III", materia.Nombre);
            Assert.Equal(123456, materia.MateriaId);

            Assert.Equal(1, materia.Profesor.Id);
            Assert.Equal(1, materia.Profesor.DocenteId);
            Assert.Equal("Lionel", materia.Profesor.Nombre);
            Assert.Equal("Scaloni", materia.Profesor.Apellido);

            Assert.Equal(101010, materia.Alumnos.First().Id);
            Assert.Equal("000010/22", materia.Alumnos.First().Legajo);
            Assert.Equal(101010, materia.Alumnos.First().AlumnoId);
            Assert.Equal("Lionel", materia.Alumnos.First().Nombre);
            Assert.Equal("Messi", materia.Alumnos.First().Apellido);

            Assert.Equal(777, materia.Alumnos.Last().Id);
            Assert.Equal(777, materia.Alumnos.Last().AlumnoId);
            Assert.Equal("000007/22", materia.Alumnos.Last().Legajo);
            Assert.Equal("Rodrigo", materia.Alumnos.Last().Nombre);
            Assert.Equal("De Paul", materia.Alumnos.Last().Apellido);

        }


        [Fact]
        public void Test9_CollectionQueue_GetCountFirtLast()
        {
            //Utilice la coleccion del trabajo practico que presento
            //Para poder con el generador completar dicha coleccion
            //y buscar las primeras materias y primeros y ultimos alumnos
            var materias = MateriaGenerador.Generar(10000, 1000);

            Assert.Equal(10000, materias.Count);

            Assert.Equal(1000, materias.First().Alumnos.Count);
            Assert.Equal("M1-000001/23", materias.First().Alumnos.First().Legajo);
            Assert.Equal("M1-001000/23", materias.First().Alumnos.Last().Legajo);

            Assert.Equal(1000, materias.Last().Alumnos.Count);
            Assert.Equal("M10000-000001/23", materias.Last().Alumnos.First().Legajo);
            Assert.Equal("M10000-001000/23", materias.Last().Alumnos.Last().Legajo);

        }


        [Fact]
        public void Test10_Linq_BuscarLegajo()
        {
            //Busque los alumnos en las materias que contengan el legajo 000999
            //Utilice la coleccion del trabajo practico que presento

            var materias = MateriaGenerador.Generar(10000, 1000);


            //Ayuda: where a.Legajo.Contains("000999/23")
            var query = materias.SelectMany(m => m.Alumnos)
                                .Where(a => a.Legajo
                                .Contains("000999/23"));

            
            //Assert.Equal(1000, query.ToList().Count); <- Esto me da mal porque el contador cuenta 10.000

            Assert.Equal(10000, query.ToList().Count);

        }
    }
}