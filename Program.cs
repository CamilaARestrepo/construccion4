// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int opcion;

do
{
  Console.WriteLine("1.Calculadora de facciones");
  Console.WriteLine("2.Generador de tablas de multiplicar");
  Console.WriteLine("3.Numero especial");
  Console.WriteLine("4.Adivinaza de frase oculta");
  Console.WriteLine("5.Salir");
  opcion = Int32.Parse(Console.ReadLine());

  switch (opcion)
  {
    case 1:
      int operador;
      int N1, N2, D1, D2, tot, R1, R2, a, b, MCMND, NN1, NN2, MCM;
      Console.WriteLine("Ingresar primer numerador");
      N1 = Int32.Parse(Console.ReadLine());
      Console.WriteLine("Ingresar primer denominador");
      D1 = Int32.Parse(Console.ReadLine());

      Console.WriteLine("Ingresar segundo numerador");
      N2 = Int32.Parse(Console.ReadLine());
      Console.WriteLine("Ingresar segundo denominador");
      D2 = Int32.Parse(Console.ReadLine());

      Console.WriteLine("Ingrese la operacion que desea hacer");
      Console.WriteLine(" 1.suma");
      Console.WriteLine("2.resta");
      Console.WriteLine("3.multiplicacion");
      Console.WriteLine("4.division");
      operador = Int32.Parse(Console.ReadLine());

      if (operador == 1 && D1 == D2)
      {
        tot = (N1 + N2) / D1;
        Console.WriteLine("LA SUMA DE LA FRACCION ES " + "\n" + N1 + "  " + N2 + "\n" + D1 + "   " + D2 + "=" + "  " + tot);
      }
      else if (operador == 1 && D1 != D2)
      {
        a = D1;
        b = D2;

        while (b != 0)
        {
          MCM = a;
          a = b;
          b = MCM % b;
        }
        MCMND = D1 * D2 / a;
        NN1 = MCMND / D1 * N1;
        NN2 = MCMND / D2 * N2;
        tot = NN1 + NN2;


        Console.WriteLine("LA SUMA DE LA FRACCION ES " + "\n" + N1 + "  " + N2 + "\n" + D1 + "   " + D2 + "=" + "  " + tot +"/"+ MCMND);


      }
      else if (operador == 2 && D1 == D2)
      {
        tot = (N1 - N2) / D1;
        Console.WriteLine("LA RESTA DE LA FRACCION ES " + "\n" + N1 + "  " + N2 + "\n" + D1 + "   " + D2 + "=" + "  " + tot);
      }
      else if (operador == 2 && D1 != D2)
      {
        a = D1;
        b = D2;

        while (b != 0)
        {
          MCM = a;
          a = b;
          b = MCM % b;
        }
        MCMND = D1 * D2 / a;
        NN1 = MCMND / D1 * N1;
        NN2 = MCMND / D2 * N2;
        tot = NN1 - NN2;

        Console.WriteLine("LA RESTA DE LA FRACCION ES " + "\n" + N1 + "  " + N2 + "\n" + D1 + "   " + D2 + "=" + "  " + tot +"/"+ MCMND);
      }
      else if (operador == 3)
      {
        int mn = N1 * N2  ;
        int md=D1 * D2;
        
        Console.WriteLine("LA MULTIPLICACION DE LA FRACCION ES " + "\n" + N1 + "  " + N2 + "\n" + D1 + "   " + D2 + "=" + "  " + mn+"/"+md);
      }
      else if (operador == 4 && D1 != 0)
      {
        tot = N1 * D2;
         int to2= N2 * D1;
        Console.WriteLine("LA DIVISION DE LA FRACCION ES " + "\n" + N1 + "  " + N2 + "\n" + D1 + "   " + D2 + "=" + "  " + tot+"/"+to2);

      }
      else if (operador == 4 && D1 == 0)
      {
        Console.WriteLine("NO SE PUEDE DIVIDIR POR 0 ERROR");
      }
      break;

    case 2:
      int tabla1, tabla2, RESPUESTA;
      Console.WriteLine("digiteme el primer rango");
      tabla1 = Int32.Parse(Console.ReadLine());
      Console.WriteLine("digiteme el limite del rango");
      tabla2 = Int32.Parse(Console.ReadLine());
      Random random = new Random();
      for (int num = tabla1; num <= tabla2; num++)
      {
        Console.WriteLine("tabla de multiplicar" + num);
        Console.WriteLine("=========================");
        RESPUESTA = random.Next(1, 11);
        for (int i = 1; i <= 10; i++)
        {
          int resul = num * i;
          Console.WriteLine(num + " x " + i + " = " + resul);
          if (i == RESPUESTA)
          {
            Console.WriteLine(num + " x " + "?" + " = " + resul);
            Console.WriteLine("dIngresa tu respuesta");
            RESPUESTA = Int32.Parse(Console.ReadLine());
            if (RESPUESTA == i)
            {
              Console.WriteLine("¡Correcto!");
            }
            else
            {
              Console.WriteLine("Incorrecto. El resultado es" + i);
            }
          }
          
        }
      }
      break;

    case 3:
      float NumEspecial;
      Console.WriteLine("DIGITE EL NUMERO ESPECIAL ");
      Console.WriteLine("_________________________");
      Console.WriteLine("1.Es divisible entre 5.");
      Console.WriteLine("2.No es divisible entre 2 ni 3. ");
      Console.WriteLine("3.La suma de sus dígitos es mayor a 10.");
      NumEspecial = float.Parse(Console.ReadLine());
      float resulnum = NumEspecial % 5;
      float resulnm2 = NumEspecial % 2;
      float resulnm3 = NumEspecial % 3;
      if (resulnum == 0 && resulnm2 != 0 && resulnm3 != 0)
      {
        float Suma = 0;
        float numn = NumEspecial;
        while (numn > 0)
        {
          Suma = Suma + numn % 10;
          numn = numn / 10;
        }
        if (Suma > 10)
        {
          Console.WriteLine("es un numero especial");

        }
        else
        {
          Console.WriteLine("No un numero especial");
        }

      }
      else
      {
        Console.WriteLine("No un numero especial ");
      }
      break;


    case 4:

      int conta = 0;
      int validador = 0;
      string p1 = "gato";
      string p2 = "en";
      string p3 = "jardin";
      int palabra1 = 0;
      int palabra2 = 0;
      int palabra3 = 0;
      int conta2 = 0;
      string M1 = "__";
      string M2 = "__";
      string M3 = "__";
      int intentos = 10;
      Console.WriteLine("-----------------------");
      Console.WriteLine("La frase ha completar es:");
      Console.WriteLine("El " + M1 + " juega " + M2 + " el " + M3);
      Console.WriteLine("Cantidad de intentos " + intentos);
      Console.WriteLine("-----------------------");
      Console.WriteLine("-----------------------");

      while (conta < 10 && conta2 < 3)
      {
        conta++;
        int h = intentos - conta;
        Console.WriteLine("ingresa la palabra en minuscula:");
        Console.WriteLine("-----------------------");
        string palabra = Console.ReadLine().ToLower();

        if (palabra == p1 || palabra == p2 || palabra == p3)
        {

          if (palabra1 == 1 && palabra == p1)
          {

            Console.WriteLine("Palabra ya fue ingresada");
            Console.WriteLine("Cantidad de intentos " + h);
            Console.WriteLine("-----------------------");
          }
          else if (palabra1 == 0 && palabra == p1)
          {
            M1 = p1;
            palabra1 = 1;
            conta2++;
            Console.WriteLine("Felicidades has acertado una palabra");

          }
          else if (palabra2 == 1 && palabra == p2)
          {
            Console.WriteLine("Palabra ya fue ingresada");
            Console.WriteLine("Cantidad de intentos " + h);
            Console.WriteLine("-----------------------");
          }
          else if (palabra2 == 0 && palabra == p2)
          {
            M2 = p2;
            palabra2 = 1;
            conta2++;
            Console.WriteLine("Felicidades has acertado una palabra");

          }
          else if (palabra3 == 1 && palabra == p3)
          {
            Console.WriteLine("Palabra ya fue ingresada");
            Console.WriteLine("Cantidad de intentos " + h);
            Console.WriteLine("-----------------------");
          }
          else if (palabra3 == 0 && palabra == p3)
          {
            M3 = p3;
            palabra3 = 1;
            conta2++;
            Console.WriteLine("Felicidades has acertado una palabra");

          }

          Console.WriteLine("El " + M1 + " juega " + M2 + " el " + M3);
          Console.WriteLine("Cantidad de intentos " + h);
          Console.WriteLine("-----------------------");
        }
        else
        {
          Console.WriteLine("Palabra incorrecta");
          Console.WriteLine("El " + M1 + " juega " + M2 + " el " + M3);
          Console.WriteLine("Cantidad de intentos " + h);
          Console.WriteLine("-----------------------");
        }

      }

      if (conta == 5)
      {
        Console.WriteLine("Moriste!");
        Console.WriteLine("-----------------------");
        conta = 0;
        conta2 = 0;
      }
      if (conta2 == 3)
      {
        Console.WriteLine("Ganaste!");
        Console.WriteLine("-----------------------");
        conta2 = 0;
        conta = 0;
        Console.WriteLine("El " + M1 + " juega " + M2 + " el " + M3);
      }
      
      break;
      case 5:
      break;
    default:
      Console.WriteLine("ingresa una opción valida");
      break;
  }


} while (opcion !=5);