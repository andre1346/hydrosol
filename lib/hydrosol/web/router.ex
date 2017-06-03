defmodule Hydrosol.Web.Router do
  use Hydrosol.Web, :router

  pipeline :browser do
    plug :accepts, ["html"]
    plug :fetch_session
    plug :fetch_flash
    plug :protect_from_forgery
    plug :put_secure_browser_headers

  end

  pipeline :api do
    plug :accepts, ["json"]
  end

  scope "/", Hydrosol.Web do
    pipe_through :browser # Use the default browser stack

    get "/", PageController, :index
    get "/a-propos", PageController, :about
    get "/residentiel/services", PageController, :res_services
    get "/residentiel/produits", PageController, :res_produits
    get "/residentiel/realisations", PageController, :res_realisations
    get "/commercial/services", PageController, :com_services
    get "/commercial/produits", PageController, :com_produits
    get "/commercial/realisations", PageController, :com_realisations
    get "/contact", PageController, :contact
    get "/demande-de-soumission-residentiel-ou-commercial", PageController, :soumission
    get "/nouvelles", PageController, :nouvelles
    resources "/residentiels", ResidentielController
    resources "/commercials", CommercialController
    get "/faq", PageController, :faq
    
end

  # Other scopes may use custom stacks.
  # scope "/api", Hydrosol.Web do
  #   pipe_through :api
  # end

end
