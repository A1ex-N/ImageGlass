﻿using System.Collections.Generic;
using System.Globalization;

namespace ImageGlass.Base
{
    public static class Constants
    {
        public const int MENU_ICON_HEIGHT = 21;
        public const int TOOLBAR_ICON_HEIGHT = 20;
        public const int TOOLBAR_HEIGHT = 40;
        public const int VIEWER_GRID_SIZE = 8;

        /// <summary>
        /// First launch version constant. 
        /// If the value read from config file is less than this value, 
        /// the First-Launch Configs screen will be launched.
        /// </summary>
        public const int FIRST_LAUNCH_VERSION = 5;


        /// <summary>
        /// The URI Scheme to register web-to-app linking
        /// </summary>
        public const string URI_SCHEME = "imageglass";


        /// <summary>
        /// Gets built-in image formats
        /// </summary>
        public const string IMAGE_FORMATS = "*.bmp;*.cur;*.cut;*.dds;*.dib;*.emf;*.exif;*.gif;*.heic;*.ico;*.jfif;*.jpe;*.jpeg;*.jpg;*.pbm;*.pcx;*.pgm;*.png;*.ppm;*.psb;*.svg;*.tif;*.tiff;*.webp;*.wmf;*.wpg;*.xbm;*.xpm;*.exr;*.hdr;*.psd;*.tga;*.3fr;*.ari;*.arw;*.bay;*.crw;*.cr2;*.cap;*.dcs;*.dcr;*.dng;*.drf;*.eip;*.erf;*.fff;*.gpr;*.iiq;*.k25;*.kdc;*.mdc;*.mef;*.mos;*.mrw;*.nef;*.nrw;*.obm;*.orf;*.pef;*.ptx;*.pxn;*.r3d;*.raf;*.raw;*.rwl;*.rw2;*.rwz;*.sr2;*.srf;*.srw;*.x3f";


        /// <summary>
        /// Number format to use for save/restore ImageGlass settings
        /// </summary>
        public static NumberFormatInfo NumberFormat
        {
            get => new NumberFormatInfo
            {
                NegativeSign = "-"
            };
        }


        /// <summary>
        /// Gets the default set of keycombo actions
        /// </summary>
        public static Dictionary<KeyCombos, AssignableActions> DefaultKeycomboActions
        {
            get => new Dictionary<KeyCombos, AssignableActions>
                {
                    { KeyCombos.LeftRight, AssignableActions.PrevNextImage },
                    { KeyCombos.PageUpDown, AssignableActions.PrevNextImage },
                    { KeyCombos.SpaceBack, AssignableActions.PauseSlideshow },
                    { KeyCombos.UpDown, AssignableActions.PauseSlideshow }
                };
        }
    }
}
