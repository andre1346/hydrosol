defmodule Hydrosol.Web.ResidentielController do
  use Hydrosol.Web, :controller

  alias Hydrosol.Soumission

  def index(conn, _params) do
    residentiels = Soumission.list_residentiels()
    render(conn, "index.html", residentiels: residentiels)
  end

  def new(conn, _params) do
    changeset = Soumission.change_residentiel(%Hydrosol.Soumission.Residentiel{})
    render(conn, "new.html", changeset: changeset)
  end

  def create(conn, %{"residentiel" => residentiel_params}) do
    case Soumission.create_residentiel(residentiel_params) do
      {:ok, residentiel} ->
        conn
        |> put_flash(:info, "Residentiel created successfully.")
        |> redirect(to: residentiel_path(conn, :show, residentiel))
      {:error, %Ecto.Changeset{} = changeset} ->
        render(conn, "new.html", changeset: changeset)
    end
  end

  def show(conn, %{"id" => id}) do
    residentiel = Soumission.get_residentiel!(id)
    render(conn, "show.html", residentiel: residentiel)
  end

  def edit(conn, %{"id" => id}) do
    residentiel = Soumission.get_residentiel!(id)
    changeset = Soumission.change_residentiel(residentiel)
    render(conn, "edit.html", residentiel: residentiel, changeset: changeset)
  end

  def update(conn, %{"id" => id, "residentiel" => residentiel_params}) do
    residentiel = Soumission.get_residentiel!(id)

    case Soumission.update_residentiel(residentiel, residentiel_params) do
      {:ok, residentiel} ->
        conn
        |> put_flash(:info, "Residentiel updated successfully.")
        |> redirect(to: residentiel_path(conn, :show, residentiel))
      {:error, %Ecto.Changeset{} = changeset} ->
        render(conn, "edit.html", residentiel: residentiel, changeset: changeset)
    end
  end

  def delete(conn, %{"id" => id}) do
    residentiel = Soumission.get_residentiel!(id)
    {:ok, _residentiel} = Soumission.delete_residentiel(residentiel)

    conn
    |> put_flash(:info, "Residentiel deleted successfully.")
    |> redirect(to: residentiel_path(conn, :index))
  end
end
