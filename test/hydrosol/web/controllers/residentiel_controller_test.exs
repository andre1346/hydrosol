defmodule Hydrosol.Web.ResidentielControllerTest do
  use Hydrosol.Web.ConnCase

  alias Hydrosol.Soumission

  @create_attrs %{address: "some address", codepostal: "some codepostal", comment: "some comment", complementaire: "some complementaire", easy_access: true, email: "some email", etat_terrain: "some etat_terrain", fournisseur: "some fournisseur", info_projet: "some info_projet", irrigation: true, nom: "some nom", pente: "some pente", prenom: "some prenom", superficie: "some superficie", tel: "some tel", ville: "some ville"}
  @update_attrs %{address: "some updated address", codepostal: "some updated codepostal", comment: "some updated comment", complementaire: "some updated complementaire", easy_access: false, email: "some updated email", etat_terrain: "some updated etat_terrain", fournisseur: "some updated fournisseur", info_projet: "some updated info_projet", irrigation: false, nom: "some updated nom", pente: "some updated pente", prenom: "some updated prenom", superficie: "some updated superficie", tel: "some updated tel", ville: "some updated ville"}
  @invalid_attrs %{address: nil, codepostal: nil, comment: nil, complementaire: nil, easy_access: nil, email: nil, etat_terrain: nil, fournisseur: nil, info_projet: nil, irrigation: nil, nom: nil, pente: nil, prenom: nil, superficie: nil, tel: nil, ville: nil}

  def fixture(:residentiel) do
    {:ok, residentiel} = Soumission.create_residentiel(@create_attrs)
    residentiel
  end

  test "lists all entries on index", %{conn: conn} do
    conn = get conn, residentiel_path(conn, :index)
    assert html_response(conn, 200) =~ "Listing Residentiels"
  end

  test "renders form for new residentiels", %{conn: conn} do
    conn = get conn, residentiel_path(conn, :new)
    assert html_response(conn, 200) =~ "New Residentiel"
  end

  test "creates residentiel and redirects to show when data is valid", %{conn: conn} do
    conn = post conn, residentiel_path(conn, :create), residentiel: @create_attrs

    assert %{id: id} = redirected_params(conn)
    assert redirected_to(conn) == residentiel_path(conn, :show, id)

    conn = get conn, residentiel_path(conn, :show, id)
    assert html_response(conn, 200) =~ "Show Residentiel"
  end

  test "does not create residentiel and renders errors when data is invalid", %{conn: conn} do
    conn = post conn, residentiel_path(conn, :create), residentiel: @invalid_attrs
    assert html_response(conn, 200) =~ "New Residentiel"
  end

  test "renders form for editing chosen residentiel", %{conn: conn} do
    residentiel = fixture(:residentiel)
    conn = get conn, residentiel_path(conn, :edit, residentiel)
    assert html_response(conn, 200) =~ "Edit Residentiel"
  end

  test "updates chosen residentiel and redirects when data is valid", %{conn: conn} do
    residentiel = fixture(:residentiel)
    conn = put conn, residentiel_path(conn, :update, residentiel), residentiel: @update_attrs
    assert redirected_to(conn) == residentiel_path(conn, :show, residentiel)

    conn = get conn, residentiel_path(conn, :show, residentiel)
    assert html_response(conn, 200) =~ "some updated address"
  end

  test "does not update chosen residentiel and renders errors when data is invalid", %{conn: conn} do
    residentiel = fixture(:residentiel)
    conn = put conn, residentiel_path(conn, :update, residentiel), residentiel: @invalid_attrs
    assert html_response(conn, 200) =~ "Edit Residentiel"
  end

  test "deletes chosen residentiel", %{conn: conn} do
    residentiel = fixture(:residentiel)
    conn = delete conn, residentiel_path(conn, :delete, residentiel)
    assert redirected_to(conn) == residentiel_path(conn, :index)
    assert_error_sent 404, fn ->
      get conn, residentiel_path(conn, :show, residentiel)
    end
  end
end
