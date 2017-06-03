defmodule Hydrosol.Web.CommercialControllerTest do
  use Hydrosol.Web.ConnCase

  alias Hydrosol.Soumission

  @create_attrs %{address: "some address", adresse_projet: "some adresse_projet", caracteristique_travaux: "some caracteristique_travaux", codepostal: "some codepostal", comment: "some comment", complementaire: "some complementaire", contact: "some contact", easy_access: true, echeance: "some echeance", email: "some email", etat_terrain: "some etat_terrain", fournisseur: "some fournisseur", info_projet: "some info_projet", irrigation: true, more_detail_echeance: "some more_detail_echeance", nom: "some nom", pente: "some pente", superficie: "some superficie", tel: "some tel", type_service: "some type_service", ville: "some ville"}
  @update_attrs %{address: "some updated address", adresse_projet: "some updated adresse_projet", caracteristique_travaux: "some updated caracteristique_travaux", codepostal: "some updated codepostal", comment: "some updated comment", complementaire: "some updated complementaire", contact: "some updated contact", easy_access: false, echeance: "some updated echeance", email: "some updated email", etat_terrain: "some updated etat_terrain", fournisseur: "some updated fournisseur", info_projet: "some updated info_projet", irrigation: false, more_detail_echeance: "some updated more_detail_echeance", nom: "some updated nom", pente: "some updated pente", superficie: "some updated superficie", tel: "some updated tel", type_service: "some updated type_service", ville: "some updated ville"}
  @invalid_attrs %{address: nil, adresse_projet: nil, caracteristique_travaux: nil, codepostal: nil, comment: nil, complementaire: nil, contact: nil, easy_access: nil, echeance: nil, email: nil, etat_terrain: nil, fournisseur: nil, info_projet: nil, irrigation: nil, more_detail_echeance: nil, nom: nil, pente: nil, superficie: nil, tel: nil, type_service: nil, ville: nil}

  def fixture(:commercial) do
    {:ok, commercial} = Soumission.create_commercial(@create_attrs)
    commercial
  end

  test "lists all entries on index", %{conn: conn} do
    conn = get conn, commercial_path(conn, :index)
    assert html_response(conn, 200) =~ "Listing Commercials"
  end

  test "renders form for new commercials", %{conn: conn} do
    conn = get conn, commercial_path(conn, :new)
    assert html_response(conn, 200) =~ "New Commercial"
  end

  test "creates commercial and redirects to show when data is valid", %{conn: conn} do
    conn = post conn, commercial_path(conn, :create), commercial: @create_attrs

    assert %{id: id} = redirected_params(conn)
    assert redirected_to(conn) == commercial_path(conn, :show, id)

    conn = get conn, commercial_path(conn, :show, id)
    assert html_response(conn, 200) =~ "Show Commercial"
  end

  test "does not create commercial and renders errors when data is invalid", %{conn: conn} do
    conn = post conn, commercial_path(conn, :create), commercial: @invalid_attrs
    assert html_response(conn, 200) =~ "New Commercial"
  end

  test "renders form for editing chosen commercial", %{conn: conn} do
    commercial = fixture(:commercial)
    conn = get conn, commercial_path(conn, :edit, commercial)
    assert html_response(conn, 200) =~ "Edit Commercial"
  end

  test "updates chosen commercial and redirects when data is valid", %{conn: conn} do
    commercial = fixture(:commercial)
    conn = put conn, commercial_path(conn, :update, commercial), commercial: @update_attrs
    assert redirected_to(conn) == commercial_path(conn, :show, commercial)

    conn = get conn, commercial_path(conn, :show, commercial)
    assert html_response(conn, 200) =~ "some updated address"
  end

  test "does not update chosen commercial and renders errors when data is invalid", %{conn: conn} do
    commercial = fixture(:commercial)
    conn = put conn, commercial_path(conn, :update, commercial), commercial: @invalid_attrs
    assert html_response(conn, 200) =~ "Edit Commercial"
  end

  test "deletes chosen commercial", %{conn: conn} do
    commercial = fixture(:commercial)
    conn = delete conn, commercial_path(conn, :delete, commercial)
    assert redirected_to(conn) == commercial_path(conn, :index)
    assert_error_sent 404, fn ->
      get conn, commercial_path(conn, :show, commercial)
    end
  end
end
