using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Text;

namespace FileManager
{
    class Program
    {
        private enum Side { Left, Right };

        static void Main(string[] args)
        {
            StartProgramm();
        }

        static void PrintContainersForManager()
        {
            Console.CursorVisible = false;

            Console.SetCursorPosition(1, 1);
            Console.Write("┌");
            
            for (int i = 0; i < Console.WindowWidth - 4; i++)
            {
                Console.Write("─");
            }

            Console.Write("┐");

            for (int i = 0; i < Console.WindowHeight - 4; i++)
            {
                Console.SetCursorPosition(Console.WindowWidth - 2, i + 2);
                Console.Write("│");
            }

            Console.SetCursorPosition(Console.WindowWidth - 2, Console.WindowHeight - 2);
            Console.Write("┘");

            for (int i = Console.WindowWidth - 3; i > 1; i--)
            {
                Console.SetCursorPosition(i, Console.WindowHeight - 2);
                Console.Write("─");
            }

            Console.SetCursorPosition(1, Console.WindowHeight - 2);
            Console.Write("└");

            for (int i = Console.WindowHeight - 3; i > 1; i--)
            {
                Console.SetCursorPosition(1, i);
                Console.Write("│");
            }

            Console.SetCursorPosition(Console.WindowWidth / 2 - 1, 1);
            Console.Write("┬");

            for (int i = 0; i < Console.WindowHeight - 4; i++)
            {
                Console.SetCursorPosition(Console.WindowWidth / 2 - 1, i + 2);
                Console.Write("│");
            }

            Console.SetCursorPosition(1, 3);
            Console.Write("├");

            for (int i = 1; i < Console.WindowWidth - 2; i++)
            {
                if (i == Console.WindowWidth / 2 - 2)
                {
                    i++;
                }

                Console.Write("─");
            }

            Console.SetCursorPosition(Console.WindowWidth / 2 - 1, 3);
            Console.Write("┼");

            Console.SetCursorPosition(Console.WindowWidth / 2 - 1, Console.WindowHeight - 2);
            Console.Write("┴");

            Console.SetCursorPosition(Console.WindowWidth - 2, 3);
            Console.Write("┤");

            for (int i = 0; i < Console.WindowWidth - 2; i++)
            {
                Console.SetCursorPosition(1 + i, 5);
                Console.Write("─");
            }

            Console.SetCursorPosition(1, 5);
            Console.Write("├");

            Console.SetCursorPosition(Console.WindowWidth - 2, 5);
            Console.Write("┤");

            Console.SetCursorPosition(Console.WindowWidth / 2 - 1, 5);
            Console.Write("┼");

            Console.SetCursorPosition(Console.WindowWidth / 2 / 2 - 6, 4);
            Console.Write("│");

            Console.SetCursorPosition(Console.WindowWidth / 2 / 2 - 6, 3);
            Console.Write("┬");

            Console.SetCursorPosition(Console.WindowWidth / 2 / 2 - 6, 5);
            Console.Write("┴");

            Console.SetCursorPosition(3, 4);
            Console.Write("Название");

            Console.SetCursorPosition(Console.WindowWidth / 2 / 2 + 4, 4);
            Console.Write("│");

            Console.SetCursorPosition(Console.WindowWidth / 2 / 2 + 4, 3);
            Console.Write("┬");

            Console.SetCursorPosition(Console.WindowWidth / 2 / 2 + 4, 5);
            Console.Write("┴");

            Console.SetCursorPosition(Console.WindowWidth / 2 / 2 - 4, 4);
            Console.Write("Размер");

            Console.SetCursorPosition(Console.WindowWidth / 2 - 9, 4);
            Console.Write("│");

            Console.SetCursorPosition(Console.WindowWidth / 2 - 9, 3);
            Console.Write("┬");

            Console.SetCursorPosition(Console.WindowWidth / 2 - 9, 5);
            Console.Write("┴");

            Console.SetCursorPosition(Console.WindowWidth / 2 / 2 + 6, 4);
            Console.Write("Дата изменения");

            Console.SetCursorPosition(Console.WindowWidth / 2 - "Тип".Length - 4, 4);
            Console.Write("Тип");

            Console.SetCursorPosition(Console.WindowWidth / 2 + 1, 4);
            Console.Write("Название");

            Console.SetCursorPosition(Console.WindowWidth / 2 + 22, 4);
            Console.Write("│");

            Console.SetCursorPosition(Console.WindowWidth / 2 + 22, 3);
            Console.Write("┬");

            Console.SetCursorPosition(Console.WindowWidth / 2 + 22, 5);
            Console.Write("┴");

            Console.SetCursorPosition(Console.WindowWidth / 2 + 32, 4);
            Console.Write("│");

            Console.SetCursorPosition(Console.WindowWidth / 2 + 32, 3);
            Console.Write("┬");

            Console.SetCursorPosition(Console.WindowWidth / 2 + 32, 5);
            Console.Write("┴");

            Console.SetCursorPosition(Console.WindowWidth / 2 + 24, 4);
            Console.Write("Размер");

            Console.SetCursorPosition(Console.WindowWidth / 2 + 50, 4);
            Console.Write("│");

            Console.SetCursorPosition(Console.WindowWidth / 2 + 50, 3);
            Console.Write("┬");

            Console.SetCursorPosition(Console.WindowWidth / 2 + 50, 5);
            Console.Write("┴");

            Console.SetCursorPosition(Console.WindowWidth / 2 + 34, 4);
            Console.Write("Дата изменения");

            Console.SetCursorPosition(Console.WindowWidth / 2 + 52, 4);
            Console.Write("Тип");

            Console.SetCursorPosition(Console.WindowWidth / 2 / 2 - 2, Console.WindowHeight - 2);
            Console.Write("┬");

            Console.SetCursorPosition(Console.WindowWidth / 2 / 2 - 2, Console.WindowHeight - 1);
            Console.Write("│");

            Console.SetCursorPosition(Console.WindowWidth / 2 / 2 - 2, Console.WindowHeight);
            Console.Write("└");

            for (int i = Console.WindowWidth / 2 / 2 - 1; i < Console.WindowWidth - Console.WindowWidth / 2 / 2; i++)
                Console.Write("─");

            Console.SetCursorPosition(Console.WindowWidth / 2 - 15, Console.WindowHeight - 2);
            Console.Write("┬");

            Console.SetCursorPosition(Console.WindowWidth / 2 - 15, Console.WindowHeight - 1);
            Console.Write("│");

            Console.SetCursorPosition(Console.WindowWidth / 2 - 15, Console.WindowHeight );
            Console.Write("┴");

            Console.SetCursorPosition(Console.WindowWidth - Console.WindowWidth / 2 / 2, Console.WindowHeight - 2);
            Console.Write("┬");

            Console.SetCursorPosition(Console.WindowWidth - Console.WindowWidth / 2 / 2, Console.WindowHeight - 1);
            Console.Write("│");

            Console.SetCursorPosition(Console.WindowWidth - Console.WindowWidth / 2 / 2, Console.WindowHeight);
            Console.Write("┘");

            Console.SetCursorPosition(Console.WindowWidth / 2 - 1, Console.WindowHeight - 2);
            Console.Write("┼");

            Console.SetCursorPosition(Console.WindowWidth / 2 - 1, Console.WindowHeight - 1);
            Console.Write("│");

            Console.SetCursorPosition(Console.WindowWidth / 2 - 1, Console.WindowHeight);
            Console.Write("┴");

            Console.SetCursorPosition(Console.WindowWidth - Console.WindowWidth / 2 / 2 + 1 - 15, Console.WindowHeight - 2);
            Console.Write("┬");

            Console.SetCursorPosition(Console.WindowWidth - Console.WindowWidth / 2 / 2 + 1 - 15, Console.WindowHeight - 1);
            Console.Write("│");

            Console.SetCursorPosition(Console.WindowWidth - Console.WindowWidth / 2 / 2 + 1 - 15, Console.WindowHeight);
            Console.Write("┴");
        }

        static void PrintContainersForEditor()
        {
            int lH = Console.WindowWidth / 2 / 2;
            int rH = Console.WindowWidth - Console.WindowWidth / 2 / 2;
            int V = Console.WindowHeight / 2 / 2 - 1;

            Console.ForegroundColor = ConsoleColor.White;

            Console.SetCursorPosition(lH + 2, 1);
            Console.Write("Введите название файла");

            Console.ForegroundColor = ConsoleColor.Gray;

            Console.SetCursorPosition(lH, 2);

            for (int i = lH; i < rH; i++)
                Console.Write("─");

            Console.SetCursorPosition(lH, V);

            for (int i = lH; i < rH; i++)
                Console.Write("─");

            for (int i = 2; i < V; i++)
            {
                Console.SetCursorPosition(lH, i);
                Console.Write("│");

                Console.SetCursorPosition(rH - 1, i);
                Console.Write("│");
            }

            Console.SetCursorPosition(lH, 2);
            Console.Write("┌");

            Console.SetCursorPosition(rH - 1, 2);
            Console.Write("┐");

            Console.SetCursorPosition(lH, V);
            Console.Write("└");

            Console.SetCursorPosition(rH - 1, V);
            Console.Write("┘");

            Console.SetCursorPosition(lH + 3, 4);
            for (int i = lH + 3; i < rH - 3; i++)
                Console.Write("─");

            Console.ForegroundColor = ConsoleColor.White;

            Console.SetCursorPosition(lH + 3, V - 1);
            Console.Write("Нажмите Enter, чтобы закончить редактирование");

            Console.ForegroundColor = ConsoleColor.Green;
        }

        static void PrintPath(string path, Side side)
        {
            if (path.Length > 56)
            {
                int s = 0;

                while (path.Length > 55)
                {
                    s++;

                    string[] elements = path.Split('\\');

                    for (int i = s; i < s + 1; i++)
                    {
                        elements[i] = "...";
                    }

                    path = "";

                    for (int i = 0; i < elements.Length - 1; i++)
                    {
                        path += elements[i] + "\\";
                    }

                    path += elements[elements.Length - 1];
                }
            }


            if (side == Side.Left)
            {
                Console.SetCursorPosition(3, 2);
                Console.Write("{0}", path);
            }
            else
            {
                Console.SetCursorPosition(Console.WindowWidth / 2 + 1, 2);
                Console.Write("{0}", path);
            }
        }

        static void StartProgramm()
        {
            PrintContainersForManager();
            PrintMenu();
        }

        static void PrintMenu()
        {
            bool isRunning = true;
            string leftPath = "E:\\";
            string rightPath = "E:\\";
            string path = leftPath;
            int leftIndex = 0;
            int rightIndex = 0;
            int index = 0;
            int position = 0;
            int page = 1;
            Side side = Side.Left;

            string sourceFileName = null, destFileName = null;

            PrintElements(GetElements(leftPath), Side.Left, leftPath, index, page);
            PrintElements(GetElements(rightPath), Side.Right, rightPath, index, page);

            while (isRunning)
            {
                object[] elements = GetElements(path);

                if (elements.Length > 0)
                {
                    PrintInfo(elements[index], position, side, ConsoleColor.Red);
                }

                ConsoleKeyInfo keyInfo = Console.ReadKey();

                switch (keyInfo.Key)
                {
                    case ConsoleKey.DownArrow:
                        if (elements.Length > 0)
                            PrintInfo(elements[index], position, side, ConsoleColor.Gray);

                        index = index + 1 > elements.Length - 1 ? 0 : index + 1;

                        position = index % 22;

                        if (position == 0)
                        {
                            page = 1 + index / 22;
                            ClearSide(side);
                            PrintElements(elements, side, path, index, page);
                        }

                        break;
                    case ConsoleKey.UpArrow:
                        if (elements.Length > 0)
                            PrintInfo(elements[index], position, side, ConsoleColor.Gray);

                        index = index - 1 < 0 ? elements.Length - 1 : index - 1;

                        position = index % 22;

                        if (position == 21 || index == elements.Length - 1)
                        {
                            page = 1 + index / 22;
                            ClearSide(side);
                            PrintElements(elements, side, path, index - position, page);
                        }

                        break;
                    case ConsoleKey.LeftArrow:
                        if (side != Side.Left)
                        {
                            if (elements.Length > 0 && side != Side.Left)
                                PrintInfo(elements[index], position, side, ConsoleColor.Yellow);

                            rightIndex = index;

                            path = leftPath;
                            side = Side.Left;
                            index = leftIndex;
                            position = index % 22;
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        if (side != Side.Right)
                        {
                            if (elements.Length > 0)
                                PrintInfo(elements[index], position, side, ConsoleColor.Yellow);

                            leftIndex = index;

                            path = rightPath;
                            side = Side.Right;
                            index = rightIndex;
                            position = index % 22;
                        }
                        break;
                    case ConsoleKey.Backspace:
                        if (side == Side.Left)
                        {
                            if (leftPath != null && new DirectoryInfo(leftPath).Parent != null)
                            {
                                leftPath = new DirectoryInfo(leftPath).Parent.FullName.ToString();
                                path = leftPath;
                            }
                            else
                            {
                                leftPath = null;
                                path = null;
                            }
                        }
                        else
                        {
                            if (rightPath != null && new DirectoryInfo(rightPath).Parent != null)
                            {
                                rightPath = new DirectoryInfo(rightPath).Parent.FullName.ToString();
                                path = rightPath;
                            }
                            else
                            {
                                rightPath = null;
                                path = null;
                            }
                        }

                        if (elements.Length > 0)
                            PrintInfo(elements[index], position, side, ConsoleColor.Gray);

                        ClearSide(side);
                        index = 0;
                        position = 0;
                        page = 1;
                        PrintElements(GetElements(path), side, path, index, page);
                        break;
                    case ConsoleKey.Enter:
                        if (elements[index].GetType() == typeof(DirectoryInfo))
                        {
                            DirectoryInfo directoryInfo = (DirectoryInfo)elements[index];

                            if (side == Side.Left)
                            {
                                leftPath = directoryInfo.FullName;
                                path = leftPath;
                            }
                            else
                            {
                                rightPath = directoryInfo.FullName;
                                path = rightPath;
                            }

                            PrintInfo(elements[index], position, side, ConsoleColor.Gray);
                            index = 0;
                            position = 0;
                            page = 1;
                            ClearSide(side);
                            PrintElements(GetElements(path), side, path, index, page);
                        }
                        else if (elements[index].GetType() == typeof(DriveInfo))
                        {
                            DriveInfo driveInfo = (DriveInfo)elements[index];

                            if (side == Side.Left)
                            {
                                leftPath = driveInfo.Name;
                                path = leftPath;
                            }
                            else
                            {
                                rightPath = driveInfo.Name;
                                path = rightPath;
                            }

                            PrintInfo(elements[index], position, side, ConsoleColor.Gray);
                            index = 0;
                            position = 0;
                            page = 1;
                            ClearSide(side);
                            PrintElements(GetElements(path), side, path, index, page);
                        }
                        else
                        {
                            string pathToFile = Path.Combine(path, GetName(elements[index]));
                            System.Diagnostics.Process.Start(pathToFile);
                        }
                        break;
                    case ConsoleKey.B:
                        if ((keyInfo.Modifiers & ConsoleModifiers.Control) != 0)
                        {
                            if (elements.Length > 0 && elements[index].GetType() != typeof(DriveInfo)
                                && sourceFileName != null)
                            {
                                FileInfo info = new FileInfo(sourceFileName);

                                string fileName = info.Name;
                                string type = info.Extension;

                                try
                                {
                                    destFileName = Path.Combine(path, fileName);

                                    File.Copy(sourceFileName, destFileName);
                                }
                                catch (IOException IOe)
                                {
                                    IOe.GetBaseException();

                                    FileInfo[] infos = new DirectoryInfo(path).GetFiles();

                                    List<string> listInfos = new List<string>();
                                    
                                    foreach(FileInfo f in infos)
                                    {
                                        if (!f.Attributes.HasFlag(FileAttributes.Hidden))
                                        {
                                            listInfos.Add(f.Name);
                                        }
                                    }

                                    fileName = AddCountToFileName(fileName, type);

                                    while (listInfos.Contains(fileName))
                                    {
                                        fileName = AddCountToFileName(fileName, type);
                                    }

                                    destFileName = Path.Combine(path, fileName);

                                    File.Copy(sourceFileName, destFileName);

                                }

                                if (leftPath.Equals(rightPath))
                                {
                                    ClearSide(Side.Left);
                                    ClearSide(Side.Right);
                                    index = 0;
                                    position = 0;
                                    page = 1;
                                    PrintElements(GetElements(leftPath), Side.Left, leftPath, index, page);
                                    PrintElements(GetElements(rightPath), Side.Right, rightPath, index, page);
                                }
                                else
                                {
                                    ClearSide(side);
                                    index = 0;
                                    position = 0;
                                    page = 1;
                                    PrintElements(GetElements(path), side, path, index, page);
                                }
                                break;
                            }
                        }
                        break;
                    case ConsoleKey.X:
                        if ((keyInfo.Modifiers & ConsoleModifiers.Control) != 0)
                        {
                            if (elements.Length > 0 && elements[index].GetType() != typeof(DriveInfo)
                            && elements[index].GetType() != typeof(DirectoryInfo))
                            {
                                sourceFileName = Path.Combine(path, GetName(elements[index]));

                                PrintInfo(elements[index], position, side, ConsoleColor.Green);

                                Thread.Sleep(1000);
                            }
                        }
                        break;
                    case ConsoleKey.Delete:
                        if (elements.Length > 0 && elements[index].GetType() != typeof(DirectoryInfo)
                            && elements[index].GetType() != typeof(DriveInfo))
                        {
                            if (leftPath.Equals(rightPath))
                            {
                                File.Delete(Path.Combine(path, GetName(elements[index])));
                                ClearSide(Side.Left);
                                ClearSide(Side.Right);
                                index = index - 1 < 0 ? 0 : index - 1;
                                position = index % 22;
                                page = 1 + index / 22;
                                elements = GetElements(path);
                                PrintElements(elements, Side.Left, leftPath, index - position, page);
                                PrintElements(elements, Side.Right, rightPath, index - position, page);
                            }
                            else
                            {
                                File.Delete(Path.Combine(path, GetName(elements[index])));
                                ClearSide(side);
                                index = index - 1 < 0 ? 0 : index - 1;
                                position = index % 22;
                                page = 1 + index / 22;
                                elements = GetElements(path);
                                PrintElements(elements, side, path, index - position, page);
                            }
                        }
                        break;
                    case ConsoleKey.Add:
                        if ((keyInfo.Modifiers & ConsoleModifiers.Control) != 0)
                        {
                            if (elements.Length == 0 || elements[index].GetType() != typeof(DriveInfo))
                            {
                                Console.Clear();

                                string fileName = GetNameFromEditName();

                                Console.Clear();
                                PrintContainersForManager();

                                if (fileName.Length > 0)
                                {
                                    string fullPath = Path.Combine(path, fileName);

                                    FileStream fileStream = new FileStream(fullPath, FileMode.Create);

                                    fileStream.Close();

                                    if (leftPath.Equals(rightPath))
                                    {
                                        leftIndex++; rightIndex++;

                                        PrintElements(GetElements(leftPath), Side.Left, leftPath, leftIndex - leftIndex % 22, 1 + leftIndex / 22);
                                        PrintElements(GetElements(rightPath), Side.Right, rightPath, rightIndex - rightIndex % 22, 1 + rightIndex / 22);
                                    }
                                    else
                                    {
                                        index = index + 1 == 1 ? 0 : index + 1;
                                        position = index % 22;
                                        page = 1 + index / 22;

                                        elements = GetElements(path);

                                        PrintElements(elements, side, path, index - position, page);

                                        if (side == Side.Left)
                                        {
                                            PrintElements(GetElements(rightPath), Side.Right, rightPath, rightIndex - rightIndex % 22, 1 + rightIndex / 22);
                                        }
                                        else
                                        {
                                            PrintElements(GetElements(leftPath), Side.Left, leftPath, leftIndex - leftIndex % 22, 1 + leftIndex / 22);
                                        }
                                    }
                                }
                                else
                                {
                                    PrintElements(GetElements(leftPath), Side.Left, leftPath, leftIndex, 1);
                                    PrintElements(GetElements(rightPath), Side.Right, rightPath, rightIndex, 1);
                                }
                            }
                        }
                        break;
                }
            }
        }

        static void PrintElements(object[] elements, Side side, string path, int index, int page)
        {
            PrintSlider(elements.Length, page, side);
            PrintBottomInfo(elements.Length, page, side);

            if (path != null)
            {
                PrintColumns(false, side);
                PrintPath(path, side);
            }
            else
            {
                PrintColumns(true, side);
                PrintPath("\\", side);
            }

            if (elements.Length > 0)
            {
                int s = 0;

                while (index < elements.Length && s < 22)
                {
                    PrintInfo(elements[index], s, side, ConsoleColor.Gray);
                    index++;
                    s++;
                }
            }
        }

        static void PrintColumns(bool isDrives, Side side)
        {
            int[][] positions = GetPositions(side);

            int[] column_1 = { positions[0][0], positions[0][1] - 2 };
            int[] column_2 = { positions[1][0], positions[1][1] - 2 };
            int[] column_3 = { positions[2][0], positions[2][1] - 2};
            int[] column_4 = { positions[3][0], positions[3][1] - 2};

            if (isDrives)
            {
                Console.SetCursorPosition(column_1[0], column_1[1]);
                Console.Write("Имя диска");

                Console.SetCursorPosition(column_2[0], column_2[1]);
                Console.Write("Размер");

                Console.SetCursorPosition(column_3[0], column_3[1]);
                Console.Write("Осталось места");

                Console.SetCursorPosition(column_4[0], column_4[1]);
                Console.Write("Ф-МА");
            }
            else
            {
                Console.SetCursorPosition(column_1[0], column_1[1]);
                Console.Write("Название");

                Console.SetCursorPosition(column_2[0], column_2[1]);
                Console.Write("Размер");

                Console.SetCursorPosition(column_3[0], column_3[1]);
                Console.Write("Дата изменения");

                Console.SetCursorPosition(column_4[0], column_4[1]);
                Console.Write("Тип");
            }
        }

        static void PrintInfo(object obj, int index, Side side, ConsoleColor color)
        {
            int position = index % 22;

            string[] data = GetData(obj);

            string column_1;
            string column_2;
            string column_3;
            string column_4;

            column_1 = data[0];
            column_2 = data[1];
            column_3 = data[2];
            column_4 = data[3];

            column_1 = TrimName(column_1);

            if (column_4.Length > 5)
            {
                column_4 = column_4.Substring(0, 4);
            }

            int[][] positions = GetPositions(side);

            int[] namePositions = positions[0];
            int[] sizePositions = positions[1];
            int[] datePositions = positions[2];
            int[] typePositions = positions[3];

            Console.ForegroundColor = color;

            Console.SetCursorPosition(namePositions[0], namePositions[1] + position);
            Console.Write(column_1);

            Console.SetCursorPosition(sizePositions[0], sizePositions[1] + position);

            if (!column_2.Equals(""))
            {
                Console.Write(column_2);
            }

            Console.SetCursorPosition(datePositions[0], datePositions[1] + position);
            Console.Write(column_3);

            Console.SetCursorPosition(typePositions[0], typePositions[1] + position);
            Console.Write(column_4);

            if (color == ConsoleColor.Red) Console.ForegroundColor = ConsoleColor.Gray;
        }

        static void ClearSide(Side side)
        {
            int left;
            int length;

            if (side == Side.Left)
            {
                left = 3;
                length = Console.WindowWidth / 2 - 2 - 3;
            }
            else
            {
                left = Console.WindowWidth / 2 + 1;
                length = Console.WindowWidth / 2 - 3;
            }

            Console.SetCursorPosition(left, 2);

            for (int i = 0; i < length; i++)
            {
                Console.Write(" ");
            }

            for (int i = 0; i < Console.WindowHeight - 6 - 2; i++)
            {
                Console.SetCursorPosition(left, 6 + i);

                for (int k = 0; k < length; k++)
                {
                    Console.Write(" ");
                }
            }

            Console.SetCursorPosition(left, 4);
            for (int i = 0; i < 21; i++) Console.Write(" ");

            Console.SetCursorPosition(left + 23, 4);
            for (int i = 0; i < 8; i++) Console.Write(" ");

            Console.SetCursorPosition(left + 33, 4);
            for (int i = 0; i < 15; i++) Console.Write(" ");

            Console.SetCursorPosition(left + 51, 4);
            for (int i = 0; i < 5; i++) Console.Write(" ");
        }

        static object[] GetElements(string path)
        {
            ArrayList list = new ArrayList();

            if (path != null)
            {
                DirectoryInfo[] directoryInfos = new DirectoryInfo(path).GetDirectories();
                FileInfo[] fileInfos = new DirectoryInfo(path).GetFiles();

                foreach (DirectoryInfo d in directoryInfos)
                {
                    if (!d.Attributes.HasFlag(FileAttributes.Hidden))
                    {
                        list.Add(d);
                    }
                }

                foreach (FileInfo f in fileInfos)
                {
                    if (!f.Attributes.HasFlag(FileAttributes.Hidden))
                    {
                        list.Add(f);
                    }
                }
            }
            else
            {
                DriveInfo[] driveInfos = DriveInfo.GetDrives();

                foreach(DriveInfo d in driveInfos)
                {
                    if (d.IsReady) list.Add(d);
                }
            }

            return list.ToArray();
        }

        static string ClearType(string name)
        {
            int p = 0;

            char[] chars = name.ToCharArray();

            for (int i = 0; i < chars.Length; i++)
                if (chars[i] == '.') p = i;

            if (p != 0)
            {
                name = name.Remove(p);
            }

            return name;
        }

        static string TrimName(string name)
        {
            if (name.Length > 18)
            {
                name = name.Substring(0, 17) + "...";
            }

            return name;
        }

        static int[][] GetPositions(Side side)
        {
            int[] namePositions;
            int[] sizePositions;
            int[] datePositions;
            int[] typePositions;

            if (side == Side.Left)
            {
                namePositions = new int[] { 3, 6 };
                sizePositions = new int[] { Console.WindowWidth / 2 / 2 - 4, 6 };
                datePositions = new int[] { Console.WindowWidth / 2 / 2 + 6, 6 };
                typePositions = new int[] { Console.WindowWidth / 2 - "Тип".Length - 4, 6 };
            }
            else
            {
                namePositions = new int[] { Console.WindowWidth / 2 + 1, 6 };
                sizePositions = new int[] { Console.WindowWidth / 2 + 24, 6 };
                datePositions = new int[] { Console.WindowWidth / 2 + 34, 6 };
                typePositions = new int[] { Console.WindowWidth / 2 + 52, 6 };
            }

            return new int[][]
            {
                namePositions,
                sizePositions,
                datePositions,
                typePositions
            };
        }

        static string[] GetData(object obj)
        {
            string column_1 = "";
            string column_2;
            string column_3;
            string column_4;

            if (obj.GetType() == typeof(DirectoryInfo))
            {
                DirectoryInfo info = (DirectoryInfo)obj;

                column_1 = info.Name;
                column_2 = "";
                column_3 = string.Format("{0} {1}",
                info.LastWriteTime.ToShortDateString().Remove(info.LastWriteTime.ToShortDateString().Length - 4, 2),
                info.LastWriteTime.ToShortTimeString());
                column_4 = "Папка";
            }
            else if (obj.GetType() == typeof(FileInfo))
            {
                FileInfo info = (FileInfo)obj;

                column_1 = ClearType(info.Name);
                column_2 = string.Format("{0:F2} МБ", (float) info.Length / 1024 / 1024);
                column_3 = string.Format("{0} {1}",
                info.LastWriteTime.ToShortDateString().Remove(info.LastWriteTime.ToShortDateString().Length - 4, 2),
                info.LastWriteTime.ToShortTimeString());
                column_4 = info.Extension;
            }
            else
            {
                DriveInfo info = (DriveInfo)obj;

                column_1 = info.Name;
                column_2 = string.Format("{0} ГБ", info.TotalSize / 1024 / 1024 / 1024);
                column_3 = string.Format("{0} ГБ", info.TotalFreeSpace / 1024 / 1024 / 1024);
                column_4 = info.DriveFormat;
            }

            return new string[]
            {
                column_1,
                column_2,
                column_3,
                column_4
            };
        }

        static void PrintSlider(int length, int page, Side side) 
        {
            int left = side == Side.Left ? Console.WindowWidth / 2 - 1 : Console.WindowWidth - 2;

            for (int i = 0; i < 22; i++)
            {
                Console.SetCursorPosition(left, 6 + i);
                Console.Write("▒");
            }

            int pages = 1 + (length - 1) / 22;
            int percent = 22 / pages;
            int start = page * percent - percent;
            int max = page * percent;

            if (page == pages) max = 22;

            Console.ForegroundColor = ConsoleColor.White;

            while (start < max)
            {
                Console.SetCursorPosition(left, 6 + start);
                Console.Write("█");
                start++;
            }

            Console.ForegroundColor = ConsoleColor.Gray;
        }

        static string GetName(object obj)
        {
            if (obj.GetType() == typeof(DirectoryInfo))
            {
                return ((DirectoryInfo)obj).Name;
            }
            else
            {
                return ((FileInfo)obj).Name;
            }
        }

        static string AddCountToFileName(string fileName, string type)
        {
            fileName = fileName.Remove(fileName.Length - type.Length, type.Length);

            int p1 = 0, p2 = 0;

            if (fileName.Contains("(") && fileName.Contains(")"))
            {
                for (int i = 0; i < fileName.Length; i++)
                {
                    switch (fileName[i])
                    {
                        case '(': p1 = i; break;
                        case ')': p2 = i; break;
                    }
                }

                string number = fileName.Substring(p1 + 1, p2 - p1 - 1);

                int count = int.Parse(number) + 1;

                fileName = fileName.Remove(p1 + 1, p2 - p1 - 1);

                fileName = fileName.Insert(p1 + 1, count.ToString());
            }
            else
            {
                fileName += " (0)";
            }

            return fileName + type;
        }

        static void PrintBottomInfo(int length, int page, Side side)
        {
            int lH = 0;
            int rH = 0;
            int v = Console.WindowHeight - 1;

            switch (side)
            {
                case Side.Left:
                    lH = Console.WindowWidth / 2 / 2;
                    rH = Console.WindowWidth / 2 - 15 - 1 + 3;
                    break;
                case Side.Right:
                    lH = Console.WindowWidth / 2 + 1;
                    rH = Console.WindowWidth - Console.WindowWidth / 2 / 2 + 3 - 15;
                    break;
            }

            Console.SetCursorPosition(lH, v);

            for (int i = 0; i < 15; i++)
            {
                Console.Write(" ");
            }

            Console.SetCursorPosition(rH, v);

            for (int i = 0; i < 12; i++)
            {
                Console.Write(" ");
            }

            Console.SetCursorPosition(lH, v);
            Console.Write("Элементов:");

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" {0}", length);

            Console.ForegroundColor = ConsoleColor.Gray;

            Console.SetCursorPosition(rH, v);
            Console.Write("Страница:");

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" {0}", page);

            Console.ForegroundColor = ConsoleColor.Gray;
        }

        static string GetNameFromEditName()
        {
            Console.Clear();

            PrintContainersForEditor();

            StringBuilder fileName = new StringBuilder();
            bool isRunning = true;
            int lH = Console.WindowWidth / 2 / 2 + 3;
            int rH = Console.WindowWidth - Console.WindowWidth / 2 / 2 - 4;
            int V = 3;
            int index = 0;

            while (isRunning)
            {
                Console.SetCursorPosition(lH, V);
                for (int i = lH; i < rH; i++)
                    Console.Write(" ");

                Console.SetCursorPosition(lH, V);
                Console.Write(fileName);

                Console.SetCursorPosition(lH + index, V);

                ConsoleKeyInfo keyInfo = Console.ReadKey();

                if (char.IsLetter(keyInfo.KeyChar) || char.IsPunctuation(keyInfo.KeyChar))
                {
                    fileName.Insert(index, keyInfo.KeyChar);
                    index++;
                }

                switch (keyInfo.Key)
                {
                    case ConsoleKey.RightArrow:
                        index = index + 1 > fileName.Length ? 0 : index + 1;
                        break;
                    case ConsoleKey.LeftArrow:
                        if (fileName.Length > 0)
                            index = index - 1 < 0 ? fileName.Length : index - 1;
                        break;
                    case ConsoleKey.Enter:
                        Console.ForegroundColor = ConsoleColor.Gray;
                        return fileName.ToString();
                    case ConsoleKey.Spacebar:
                        fileName.Insert(index, " ");
                        index++;
                        break;
                    case ConsoleKey.Backspace:
                        if (fileName.Length > 0 && index > 0) { fileName.Remove(index - 1, 1); index--; }
                       break;
                    case ConsoleKey.Delete:
                        if (fileName.Length > 0 && index < fileName.Length)
                        {
                            fileName.Remove(index, 1);
                            index = index - 1 < 0 ? index : index - 1;
                        }
                        break;
                }
            }

            return fileName.ToString();
        }
    }
}
