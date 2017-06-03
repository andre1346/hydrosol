defmodule Hydrosol.Web.ReCommercialControllerTest do
  use Hydrosol.Web.ConnCase

  alias Hydrosol.Soumission

  @create_attrs %{address: "some address", adresse_projet: "some adresse_projet", caracteristique_travaux: "some caracteristique_travaux", codepostal: "some codepostal", comment: "some comment", complementaire: "some complementaire", contact: "some contact", easy_access: true, echeance: "some echeance", email: "some email", etat_terrain: "some etat_terrain", fournisseur: "some fournisseur", info_projet: "some info_projet", irrigation: true, more_detail_echeance: "some more_detail_echeance", nom: "some nom", pente: "some pente", superficie: "some superficie", tel: "some tel", type_service: "some type_service", ville: "some ville"}
  @update_attrs %{address: "some updated address", adresse_projet: "some updated adresse_projet", caracteristique_travaux: "some updated caracteristique_travaux", codepostal: "some updated codepostal", comment: "some updated comment", complementaire: "some updated complementaire", contact: "some updated contact", easy_access: false, echeance: "some updated echeance", email: "some updated email", etat_terrain: "some updated etat_terrain", fournisseur: "some updated fournisseur", info_projet: "some updated info_projet", irrigation: false, more_detail_echeance: "some updated more_detail_echeance", nom: "some updated nom", pente: "some updated pente", superficie: "some updated superficie", tel: "some updated tel", type_service: "some updated type_service", ville: "some updated ville"}
  @invalid_attrs %{address: nil, adresse_projet: nil, caracteristique_travaux: nil, codepostal: nil, comment: nil, complementaire: nil, contact: nil, easy_access: nil, echeance: nil, email: nil, etat_terrain: nil, fournisseur: nil, info_projet: nil, irrigation: nil, more_detail_echeance: nil, nom: nil, pente: nil, superficie: nil, tel: nil, type_service: nil, ville: nil}

  def fixture(:re_commercial) do
    {:ok, re_commercial} = Soumission.create_re_commercial(@create_attrs)
    re_commercial
  end

  test "lists all entries on index", %{conn: conn} do
    conn = get conn, re_commercial_path(conn, :index)
    assert html_response(conn, 200) =~ "Listing Commercials"
  end

  test "renders form for new commercials", %{conn: conn} do
    conn = get conn, re_commercial_path(conn, :new)
    assert html_response(conn, 200) =~ "New Re commercial"
  end

  test "creates re_commercial and redirects to show when data is valid", %{conn: conn} do
    conn = post conn, re_commercial_path(conn, :create), re_commercial: @create_attrs

    assert %{id: id} = redirected_params(conn)
    assert redirected_to(conn) == re_commercial_path(conn, :show, id)

    conn = get conn, re_commercial_path(conn, :show, id)
    assert html_response(conn, 200) =~ "Show Re commercial"
  end

  test "does not create re_commercial and renders errors when data is invalid", %{conn: conn} do
    conn = post conn, re_commercial_path(conn, :create), re_commercial: @invalid_attrs
    assert html_response(conn, 200) =~ "New Re commercial"
  end

  test "renders form for editing chosen re_commercial", %{conn: conn} do
    re_commercial = fixture(:re_commercial)
    conn = get conn, re_commercial_path(conn, :edit, re_commercial)
    assert html_response(conn, 200) =~ "Edit Re commercial"
  end

  test "updates chosen re_commercial and redirects when data is valid", %{conn: conn} do
    re_commercial = fixture(:re_commercial)
    conn = put conn, re_commercial_path(conn, :update, re_commercial), re_commercial: @update_attrs
    assert redirected_to(conn) == re_commercial_path(conn, :show, re_commercial)

    conn = get conn, re_commercial_path(conn, :show, re_commercial)
    assert html_response(conn, 200) =~ "some updated address"
  end

  test "does not update chosen re_commercial and renders errors when data is invalid", %{conn: conn} do
    re_commercial = fixture(:re_commercial)
    conn = put conn, re_commercial_path(conn, :update, re_commercial), re_commercial: @invalid_attrs
    assert html_response(conn, 200) =~ "Edit Re commercial"
  end

  test "deletes chosen re_commercial", %{conn: conn} do
    re_commercial = fixture(:re_commercial)
    conn = delete conn, re_commercial_path(conn, :delete, re_commercial)
    assert redirected_to(conn) == re_commercial_path(conn, :index)
    assert_error_sent 404, fn ->
      get conn, re_commercial_path(conn, :show, re_commercial)
    end
  end
end
