defmodule Hydrosol.Web.CommercialController do
  use Hydrosol.Web, :controller

  alias Hydrosol.Soumission

  def index(conn, _params) do
    commercials = Soumission.list_commercials()
    render(conn, "index.html", commercials: commercials)
  end

  def new(conn, _params) do
    changeset = Soumission.change_commercial(%Hydrosol.Soumission.Commercial{})
    render(conn, "new.html", changeset: changeset)
  end

  def create(conn, %{"commercial" => commercial_params}) do
    case Soumission.create_commercial(commercial_params) do
      {:ok, commercial} ->
        conn
        |> put_flash(:info, "Commercial created successfully.")
        |> redirect(to: commercial_path(conn, :show, commercial))
      {:error, %Ecto.Changeset{} = changeset} ->
        render(conn, "new.html", changeset: changeset)
    end
  end

  def show(conn, %{"id" => id}) do
    commercial = Soumission.get_commercial!(id)
    render(conn, "show.html", commercial: commercial)
  end

  def edit(conn, %{"id" => id}) do
    commercial = Soumission.get_commercial!(id)
    changeset = Soumission.change_commercial(commercial)
    render(conn, "edit.html", commercial: commercial, changeset: changeset)
  end

  def update(conn, %{"id" => id, "commercial" => commercial_params}) do
    commercial = Soumission.get_commercial!(id)

    case Soumission.update_commercial(commercial, commercial_params) do
      {:ok, commercial} ->
        conn
        |> put_flash(:info, "Commercial updated successfully.")
        |> redirect(to: commercial_path(conn, :show, commercial))
      {:error, %Ecto.Changeset{} = changeset} ->
        render(conn, "edit.html", commercial: commercial, changeset: changeset)
    end
  end

  def delete(conn, %{"id" => id}) do
    commercial = Soumission.get_commercial!(id)
    {:ok, _commercial} = Soumission.delete_commercial(commercial)

    conn
    |> put_flash(:info, "Commercial deleted successfully.")
    |> redirect(to: commercial_path(conn, :index))
  end
end
