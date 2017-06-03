defmodule Hydrosol.Web.PageController do
  use Hydrosol.Web, :controller

    def index(conn, _params) do
    render conn, "index.html"
    end

    def about(conn, _params) do
      render conn, "about.html"

    end

    def res_services(conn, _params) do
      render conn, "res_services.html"

   end

   def res_produits(conn, _params) do
    render conn, "res_produits.html"
   end

   def res_realisations(conn, _params) do
    render conn, "res_realisations.html"
   end

   def com_services(conn, _params) do
    render conn, "com_services.html"
   end

   def com_produits(conn, _params) do
    render conn, "com_produits.html"
   end

   def com_realisations(conn, _params) do
    render conn, "com_realisations.html"
   end

   def contact(conn, _params) do
    render conn, "contact.html"
   end

   def soumission(conn, _params) do
    render conn, "soumission.html"
   end

   def nouvelles(conn, _params) do
    render conn, "nouvelles.html"

   end

   def faq(conn, _params) do
    render conn, "faq.html"
   end


end
