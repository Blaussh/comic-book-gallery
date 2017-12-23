﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComicBookGallery.Models;

namespace ComicBookGallery.Data
{
    public class SeriesRepository
    {
        public Series[] GeSeries()
        {
            return Data.Series;
        }

        public Series GetSeriesData(int id)
        {
            Series seriesToReturn = null;
            foreach (var series in Data.Series)
            {
                if (series.Id == id)
                {
                    seriesToReturn = series;
                    break;
                }
            }
            if (seriesToReturn != null)
            {
                var comicBooks = new ComicBook[0];
                foreach (var comicBook in Data.ComicBooks)
                {
                    if (comicBook.Series != null && comicBook.Series.Id == id)
                    {
                        Array.Resize(ref comicBooks, comicBooks.Length +1);
                        comicBooks[comicBooks.Length - 1] = comicBook;
                    }
                }
                seriesToReturn.Issues = comicBooks;
            }
            return seriesToReturn;
        }
    }
}
