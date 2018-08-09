using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointCodeJam
{
    class Program
    {

        static void Main(string[] args)
        {
            List<int> s1 = new List<int>();
            List<int> s2 = new List<int>();
            int x = 0;
            int y = 0;
            int m1 = 0;
            int m2 = 0;
            for (int i = 0; i < 4; i++)
            {
                x = int.Parse(Console.ReadLine());
                s1.Add(x);
            }

            for (int i = 0; i < 4; i++)
            {
                y = int.Parse(Console.ReadLine());
                s2.Add(y);
            }

            int x1 = s1[0];
            int y1 = s1[1];
            int x2 = s1[2];
            int y2 = s1[3];
            int x3 = s2[0];
            int y3 = s2[1];
            int x4 = s2[2];
            int y4 = s2[3];
            string ans=calculateGeometry(x1,y1,x2,y2,x3,y3,x4,y4);
            Console.WriteLine(ans);
            Console.ReadKey();
        }

        public static string calculateGeometry(int x1, int y1,int x2, int y2, int x3, int y3, int x4,int y4)
        {
            int m1 = 0;
            int m2 = 0;
            int xmax = 0;
            int ymax = 0;
            List<int> XList = new List<int>();
            List<int> YList = new List<int>();

            if (x2 - x1 != 0)
            {
                m1 = (y2 - y1) / (x2 - x1);
            }
            else
            {
                m1 = 20000;
            }

            if (x4 - x3 != 0)
            {
                m2 = (y4 - y3) / (x4 - x3);
            }
            else
            {
                m2 = 20000;
            }

            if (m1 == 0 && m2 == 0)
            {
                if (y1 - y3 != 0)
                {
                    return "NO";
                }
                else
                {
                    if(x1==x2 && y1==y2 || x3==x4 && y3 == y4)
                    {
                        return "POINT";
                    }
                    else
                    {
                        XList.Add(x1);
                        XList.Add(x2);
                        XList.Add(x3);
                        XList.Add(x4);
                        xmax = XList.Max();
                        if (xmax == x2)
                        {
                            if (x1 <= x3 || x1 >= x3 && x1 <= x4)
                            {
                                return "SEGMENT";
                            }
                            else
                            {
                                return "NO";
                            }
                        }
                        else if (xmax==x1)
                        {
                            if (x2 <= x3 || x2 >= x3 && x2 <= x4)
                            {
                                return "SEGMENT";
                            }
                            else
                            {
                                return "NO";
                            }
                        }
                        else if (xmax == x4)
                        {
                            if (x3 <= x1 || x3 >= x1 && x3 <= x2)
                            {
                                return "SEGMENT";
                            }
                            else
                            {
                                return "NO";
                            }
                        }
                        else
                        {
                            if (x4 <= x1 || x4 >= x1 && x4 <= x2)
                            {
                                return "SEGMENT";
                            }
                            else
                            {
                                return "NO";
                            }
                        }
                      
                    }
                }
            }

            else if(m1==20000 && m2 == 20000)
            {
                if (x1 - x3 != 0)
                {
                    return "NO";
                }
                else
                {
                    if(x1==x2 && y1==y2 || x3==x4 && y3 == y4)
                    {
                        return "POINT";
                    }
                    if(y1==y3 || y1==y4 ||y2==y3 || y2== y4)
                    {
                        return "POINT";
                    }
                    else
                    {
                        YList.Add(y1);
                        YList.Add(y2);
                        YList.Add(y3);
                        YList.Add(y4);
                        ymax = YList.Max();
                        if (ymax == y1)
                        {
                            if (y2 <= y3 || y2 <= y4 && y2 >= y3)
                            {
                                return "SEGMENT";
                            }
                            else
                            {
                                return "NO";
                            }
                        }
                        else if (ymax == y2)
                        {
                            if( y1 <= y3 || y1>=y3 && y1 <= y4)
                            {
                                return "SEGMENT";
                            }
                            else
                            {
                                return "NO";
                            }
                        }
                        else if (ymax==y3)
                        {
                            if(y2<=y1 || y2>=y1 && y2 <= y3)
                            {
                                return "SEGMENT";
                            }
                            else
                            {
                                return "NO";

                            }
                        }
                        else
                        {
                            if(y3<=y1 || y3>=y1 && y3 <= y2)
                            {
                                return "SEGMENT";
                            }
                            else
                            {
                                return "NO";
                            }
                        }
                    }
                }
            }
            else
            {
                if (m1 == 20000 && m2 ==0)
                {
                    if(y1<=y3 && y2 >= y3)
                    {
                        if(x3<=x1 && x4 >= x1)
                        {
                            return "POINT";
                        }
                        else
                        {
                            return "NO";
                        }
                    }
                    else
                    {
                        return "NO";
                    }
                }
                else
                {
                    if (y3>=y1 && y4<=y1)
                    {
                        if(x1<=x3 && x2 >= x3)
                        {
                            return "POINT";
                        }
                        else
                        {
                            return "NO";
                        }
                    }
                    else
                    {
                        return "NO";
                    }
                }



            }
        }

            



        }
    }

