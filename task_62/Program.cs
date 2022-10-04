Console.WriteLine("Программа, которая спирально заполняет двумерный массив");

int[,] arrayResult = new int[4,4];
     int z;
     int x = 0;
     int y = 0;
     int k = 0;
     for (z = 1; Math.Pow(arrayResult.GetLength(1),2); z++)
     {
         arrayResult[x-1, y-1] = z;
         cout << "arr[" << x-1 << "][" << y-1 << "] = " << z << endl;
         switch (k % 4)
         {
             case 0:
                 y++;
                 if ((x+1) == y)
                     k++;
                 cout << "done! 0  ";
                 break;
             case 1:
                 x--;
                 if((n - x + 1) == y)
                     k++;
                 cout << "done! 1  ";
                 break;
             case 2:
                 y--;
                 if((n - x) == (n - y))
                     k++;
                 cout << "done! 2  ";
                 break;
             case 3:
                 x++;
                 if (y == (n - x + 1))
                     k++;
                 cout << "done! 3  ";
                 break;
             default:
                 cout << "Oh, NO! Error!" << endl;
                 break;
         }
     }

     cout << endl;
     for (int i = 0; i < 5; i++)
     {
         for (int j = 0; j < 5; j++)
         {
             cout << setw(4) << arrayResult[i][j];
         }
         cout << endl;
     }
     return 0;
 