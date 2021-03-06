exports.config = {
  // See http://brunch.io/#documentation for docs.
  files: {
    javascripts: {
      joinTo: "js/app.js",
      order: {
        before: [
          "vendor/js/jquery.js",
          "vendor/js/jquery.migrate.js",
          //"vendor/js/libs_jquery.js"
          "vendor/js/functions.js",
          "vendor/js/jsembed.js",
          //"vendor/js/jsmenu.js",
          "vendor/js/js_colorbox.js",
        //  "vendor/js/js.script.js"
        ]
      },

      //  To use a separate vendor.js bundle, specify two files path
      // http://brunch.io/docs/config#-files-
      // joinTo: {
      //  "js/app.js": /^(js)/,
      //  "js/vendor.js": /^(vendor)|(deps)/
      // }
      //
      // To change the order of concatenation of files, explicitly mention here
      // order: {
      //   before: [
      //     "vendor/js/jquery-2.1.1.js",
      //     "vendor/js/bootstrap.min.js"
      //   ]
      // }
    },
    stylesheets: {
      joinTo: "css/app.css",
      order: {
        before: [
           "vendor/css/font_google.css",
           "vendor/css/font_genericons.css",
           //"vendor/css/themes_style.css",
           "vendor/css/font_awesome.css",
           "vendor/css/font_menu.css",
           "vendor/css/font_colorbox.css",
           "vendor/css/custom.css",
           "vendor/css/responsive.css",
           "css/style.css"

        ]
      }
    },
    templates: {
      joinTo: "js/app.js"
    }
  },

  conventions: {
    // This option sets where we should place non-css and non-js assets in.
    // By default, we set this to "/assets/static". Files in this directory
    // will be copied to `paths.public`, which is "priv/static" by default.
    assets: /^(static)/
  },

  // Phoenix paths configuration
  paths: {
    // Dependencies and current project directories to watch
    watched: ["static", "css", "js", "vendor"],
    // Where to compile files to
    public: "../priv/static"
  },

  // Configure your plugins
  plugins: {
    babel: {
      // Do not use ES6 compiler in vendor code
      ignore: [/vendor/]
    }
  },

  modules: {
    autoRequire: {
      "js/app.js": ["js/app"]
    }
  },

  npm: {
    enabled: true
  }
};
