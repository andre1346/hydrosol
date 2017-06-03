defmodule Hydrosol.SoumissionTest do
  use Hydrosol.DataCase

  alias Hydrosol.Soumission

  describe "residentiels" do
    alias Hydrosol.Soumission.Residentiel

    @valid_attrs %{address: "some address", codepostal: "some codepostal", comment: "some comment", complementaire: "some complementaire", easy_access: true, email: "some email", etat_terrain: "some etat_terrain", fournisseur: "some fournisseur", info_projet: "some info_projet", irrigation: true, nom: "some nom", pente: "some pente", prenom: "some prenom", superficie: "some superficie", tel: "some tel", ville: "some ville"}
    @update_attrs %{address: "some updated address", codepostal: "some updated codepostal", comment: "some updated comment", complementaire: "some updated complementaire", easy_access: false, email: "some updated email", etat_terrain: "some updated etat_terrain", fournisseur: "some updated fournisseur", info_projet: "some updated info_projet", irrigation: false, nom: "some updated nom", pente: "some updated pente", prenom: "some updated prenom", superficie: "some updated superficie", tel: "some updated tel", ville: "some updated ville"}
    @invalid_attrs %{address: nil, codepostal: nil, comment: nil, complementaire: nil, easy_access: nil, email: nil, etat_terrain: nil, fournisseur: nil, info_projet: nil, irrigation: nil, nom: nil, pente: nil, prenom: nil, superficie: nil, tel: nil, ville: nil}

    def residentiel_fixture(attrs \\ %{}) do
      {:ok, residentiel} =
        attrs
        |> Enum.into(@valid_attrs)
        |> Soumission.create_residentiel()

      residentiel
    end

    test "list_residentiels/0 returns all residentiels" do
      residentiel = residentiel_fixture()
      assert Soumission.list_residentiels() == [residentiel]
    end

    test "get_residentiel!/1 returns the residentiel with given id" do
      residentiel = residentiel_fixture()
      assert Soumission.get_residentiel!(residentiel.id) == residentiel
    end

    test "create_residentiel/1 with valid data creates a residentiel" do
      assert {:ok, %Residentiel{} = residentiel} = Soumission.create_residentiel(@valid_attrs)
      assert residentiel.address == "some address"
      assert residentiel.codepostal == "some codepostal"
      assert residentiel.comment == "some comment"
      assert residentiel.complementaire == "some complementaire"
      assert residentiel.easy_access == true
      assert residentiel.email == "some email"
      assert residentiel.etat_terrain == "some etat_terrain"
      assert residentiel.fournisseur == "some fournisseur"
      assert residentiel.info_projet == "some info_projet"
      assert residentiel.irrigation == true
      assert residentiel.nom == "some nom"
      assert residentiel.pente == "some pente"
      assert residentiel.prenom == "some prenom"
      assert residentiel.superficie == "some superficie"
      assert residentiel.tel == "some tel"
      assert residentiel.ville == "some ville"
    end

    test "create_residentiel/1 with invalid data returns error changeset" do
      assert {:error, %Ecto.Changeset{}} = Soumission.create_residentiel(@invalid_attrs)
    end

    test "update_residentiel/2 with valid data updates the residentiel" do
      residentiel = residentiel_fixture()
      assert {:ok, residentiel} = Soumission.update_residentiel(residentiel, @update_attrs)
      assert %Residentiel{} = residentiel
      assert residentiel.address == "some updated address"
      assert residentiel.codepostal == "some updated codepostal"
      assert residentiel.comment == "some updated comment"
      assert residentiel.complementaire == "some updated complementaire"
      assert residentiel.easy_access == false
      assert residentiel.email == "some updated email"
      assert residentiel.etat_terrain == "some updated etat_terrain"
      assert residentiel.fournisseur == "some updated fournisseur"
      assert residentiel.info_projet == "some updated info_projet"
      assert residentiel.irrigation == false
      assert residentiel.nom == "some updated nom"
      assert residentiel.pente == "some updated pente"
      assert residentiel.prenom == "some updated prenom"
      assert residentiel.superficie == "some updated superficie"
      assert residentiel.tel == "some updated tel"
      assert residentiel.ville == "some updated ville"
    end

    test "update_residentiel/2 with invalid data returns error changeset" do
      residentiel = residentiel_fixture()
      assert {:error, %Ecto.Changeset{}} = Soumission.update_residentiel(residentiel, @invalid_attrs)
      assert residentiel == Soumission.get_residentiel!(residentiel.id)
    end

    test "delete_residentiel/1 deletes the residentiel" do
      residentiel = residentiel_fixture()
      assert {:ok, %Residentiel{}} = Soumission.delete_residentiel(residentiel)
      assert_raise Ecto.NoResultsError, fn -> Soumission.get_residentiel!(residentiel.id) end
    end

    test "change_residentiel/1 returns a residentiel changeset" do
      residentiel = residentiel_fixture()
      assert %Ecto.Changeset{} = Soumission.change_residentiel(residentiel)
    end
  end

  describe "commercials" do
    alias Hydrosol.Soumission.ReCommercial

    @valid_attrs %{address: "some address", adresse_projet: "some adresse_projet", caracteristique_travaux: "some caracteristique_travaux", codepostal: "some codepostal", comment: "some comment", complementaire: "some complementaire", contact: "some contact", easy_access: true, echeance: "some echeance", email: "some email", etat_terrain: "some etat_terrain", fournisseur: "some fournisseur", info_projet: "some info_projet", irrigation: true, more_detail_echeance: "some more_detail_echeance", nom: "some nom", pente: "some pente", superficie: "some superficie", tel: "some tel", type_service: "some type_service", ville: "some ville"}
    @update_attrs %{address: "some updated address", adresse_projet: "some updated adresse_projet", caracteristique_travaux: "some updated caracteristique_travaux", codepostal: "some updated codepostal", comment: "some updated comment", complementaire: "some updated complementaire", contact: "some updated contact", easy_access: false, echeance: "some updated echeance", email: "some updated email", etat_terrain: "some updated etat_terrain", fournisseur: "some updated fournisseur", info_projet: "some updated info_projet", irrigation: false, more_detail_echeance: "some updated more_detail_echeance", nom: "some updated nom", pente: "some updated pente", superficie: "some updated superficie", tel: "some updated tel", type_service: "some updated type_service", ville: "some updated ville"}
    @invalid_attrs %{address: nil, adresse_projet: nil, caracteristique_travaux: nil, codepostal: nil, comment: nil, complementaire: nil, contact: nil, easy_access: nil, echeance: nil, email: nil, etat_terrain: nil, fournisseur: nil, info_projet: nil, irrigation: nil, more_detail_echeance: nil, nom: nil, pente: nil, superficie: nil, tel: nil, type_service: nil, ville: nil}

    def re_commercial_fixture(attrs \\ %{}) do
      {:ok, re_commercial} =
        attrs
        |> Enum.into(@valid_attrs)
        |> Soumission.create_re_commercial()

      re_commercial
    end

    test "list_commercials/0 returns all commercials" do
      re_commercial = re_commercial_fixture()
      assert Soumission.list_commercials() == [re_commercial]
    end

    test "get_re_commercial!/1 returns the re_commercial with given id" do
      re_commercial = re_commercial_fixture()
      assert Soumission.get_re_commercial!(re_commercial.id) == re_commercial
    end

    test "create_re_commercial/1 with valid data creates a re_commercial" do
      assert {:ok, %ReCommercial{} = re_commercial} = Soumission.create_re_commercial(@valid_attrs)
      assert re_commercial.address == "some address"
      assert re_commercial.adresse_projet == "some adresse_projet"
      assert re_commercial.caracteristique_travaux == "some caracteristique_travaux"
      assert re_commercial.codepostal == "some codepostal"
      assert re_commercial.comment == "some comment"
      assert re_commercial.complementaire == "some complementaire"
      assert re_commercial.contact == "some contact"
      assert re_commercial.easy_access == true
      assert re_commercial.echeance == "some echeance"
      assert re_commercial.email == "some email"
      assert re_commercial.etat_terrain == "some etat_terrain"
      assert re_commercial.fournisseur == "some fournisseur"
      assert re_commercial.info_projet == "some info_projet"
      assert re_commercial.irrigation == true
      assert re_commercial.more_detail_echeance == "some more_detail_echeance"
      assert re_commercial.nom == "some nom"
      assert re_commercial.pente == "some pente"
      assert re_commercial.superficie == "some superficie"
      assert re_commercial.tel == "some tel"
      assert re_commercial.type_service == "some type_service"
      assert re_commercial.ville == "some ville"
    end

    test "create_re_commercial/1 with invalid data returns error changeset" do
      assert {:error, %Ecto.Changeset{}} = Soumission.create_re_commercial(@invalid_attrs)
    end

    test "update_re_commercial/2 with valid data updates the re_commercial" do
      re_commercial = re_commercial_fixture()
      assert {:ok, re_commercial} = Soumission.update_re_commercial(re_commercial, @update_attrs)
      assert %ReCommercial{} = re_commercial
      assert re_commercial.address == "some updated address"
      assert re_commercial.adresse_projet == "some updated adresse_projet"
      assert re_commercial.caracteristique_travaux == "some updated caracteristique_travaux"
      assert re_commercial.codepostal == "some updated codepostal"
      assert re_commercial.comment == "some updated comment"
      assert re_commercial.complementaire == "some updated complementaire"
      assert re_commercial.contact == "some updated contact"
      assert re_commercial.easy_access == false
      assert re_commercial.echeance == "some updated echeance"
      assert re_commercial.email == "some updated email"
      assert re_commercial.etat_terrain == "some updated etat_terrain"
      assert re_commercial.fournisseur == "some updated fournisseur"
      assert re_commercial.info_projet == "some updated info_projet"
      assert re_commercial.irrigation == false
      assert re_commercial.more_detail_echeance == "some updated more_detail_echeance"
      assert re_commercial.nom == "some updated nom"
      assert re_commercial.pente == "some updated pente"
      assert re_commercial.superficie == "some updated superficie"
      assert re_commercial.tel == "some updated tel"
      assert re_commercial.type_service == "some updated type_service"
      assert re_commercial.ville == "some updated ville"
    end

    test "update_re_commercial/2 with invalid data returns error changeset" do
      re_commercial = re_commercial_fixture()
      assert {:error, %Ecto.Changeset{}} = Soumission.update_re_commercial(re_commercial, @invalid_attrs)
      assert re_commercial == Soumission.get_re_commercial!(re_commercial.id)
    end

    test "delete_re_commercial/1 deletes the re_commercial" do
      re_commercial = re_commercial_fixture()
      assert {:ok, %ReCommercial{}} = Soumission.delete_re_commercial(re_commercial)
      assert_raise Ecto.NoResultsError, fn -> Soumission.get_re_commercial!(re_commercial.id) end
    end

    test "change_re_commercial/1 returns a re_commercial changeset" do
      re_commercial = re_commercial_fixture()
      assert %Ecto.Changeset{} = Soumission.change_re_commercial(re_commercial)
    end
  end

  describe "commercials" do
    alias Hydrosol.Soumission.Commercial

    @valid_attrs %{address: "some address", adresse_projet: "some adresse_projet", caracteristique_travaux: "some caracteristique_travaux", codepostal: "some codepostal", comment: "some comment", complementaire: "some complementaire", contact: "some contact", easy_access: true, echeance: "some echeance", email: "some email", etat_terrain: "some etat_terrain", fournisseur: "some fournisseur", info_projet: "some info_projet", irrigation: true, more_detail_echeance: "some more_detail_echeance", nom: "some nom", pente: "some pente", superficie: "some superficie", tel: "some tel", type_service: "some type_service", ville: "some ville"}
    @update_attrs %{address: "some updated address", adresse_projet: "some updated adresse_projet", caracteristique_travaux: "some updated caracteristique_travaux", codepostal: "some updated codepostal", comment: "some updated comment", complementaire: "some updated complementaire", contact: "some updated contact", easy_access: false, echeance: "some updated echeance", email: "some updated email", etat_terrain: "some updated etat_terrain", fournisseur: "some updated fournisseur", info_projet: "some updated info_projet", irrigation: false, more_detail_echeance: "some updated more_detail_echeance", nom: "some updated nom", pente: "some updated pente", superficie: "some updated superficie", tel: "some updated tel", type_service: "some updated type_service", ville: "some updated ville"}
    @invalid_attrs %{address: nil, adresse_projet: nil, caracteristique_travaux: nil, codepostal: nil, comment: nil, complementaire: nil, contact: nil, easy_access: nil, echeance: nil, email: nil, etat_terrain: nil, fournisseur: nil, info_projet: nil, irrigation: nil, more_detail_echeance: nil, nom: nil, pente: nil, superficie: nil, tel: nil, type_service: nil, ville: nil}

    def commercial_fixture(attrs \\ %{}) do
      {:ok, commercial} =
        attrs
        |> Enum.into(@valid_attrs)
        |> Soumission.create_commercial()

      commercial
    end

    test "list_commercials/0 returns all commercials" do
      commercial = commercial_fixture()
      assert Soumission.list_commercials() == [commercial]
    end

    test "get_commercial!/1 returns the commercial with given id" do
      commercial = commercial_fixture()
      assert Soumission.get_commercial!(commercial.id) == commercial
    end

    test "create_commercial/1 with valid data creates a commercial" do
      assert {:ok, %Commercial{} = commercial} = Soumission.create_commercial(@valid_attrs)
      assert commercial.address == "some address"
      assert commercial.adresse_projet == "some adresse_projet"
      assert commercial.caracteristique_travaux == "some caracteristique_travaux"
      assert commercial.codepostal == "some codepostal"
      assert commercial.comment == "some comment"
      assert commercial.complementaire == "some complementaire"
      assert commercial.contact == "some contact"
      assert commercial.easy_access == true
      assert commercial.echeance == "some echeance"
      assert commercial.email == "some email"
      assert commercial.etat_terrain == "some etat_terrain"
      assert commercial.fournisseur == "some fournisseur"
      assert commercial.info_projet == "some info_projet"
      assert commercial.irrigation == true
      assert commercial.more_detail_echeance == "some more_detail_echeance"
      assert commercial.nom == "some nom"
      assert commercial.pente == "some pente"
      assert commercial.superficie == "some superficie"
      assert commercial.tel == "some tel"
      assert commercial.type_service == "some type_service"
      assert commercial.ville == "some ville"
    end

    test "create_commercial/1 with invalid data returns error changeset" do
      assert {:error, %Ecto.Changeset{}} = Soumission.create_commercial(@invalid_attrs)
    end

    test "update_commercial/2 with valid data updates the commercial" do
      commercial = commercial_fixture()
      assert {:ok, commercial} = Soumission.update_commercial(commercial, @update_attrs)
      assert %Commercial{} = commercial
      assert commercial.address == "some updated address"
      assert commercial.adresse_projet == "some updated adresse_projet"
      assert commercial.caracteristique_travaux == "some updated caracteristique_travaux"
      assert commercial.codepostal == "some updated codepostal"
      assert commercial.comment == "some updated comment"
      assert commercial.complementaire == "some updated complementaire"
      assert commercial.contact == "some updated contact"
      assert commercial.easy_access == false
      assert commercial.echeance == "some updated echeance"
      assert commercial.email == "some updated email"
      assert commercial.etat_terrain == "some updated etat_terrain"
      assert commercial.fournisseur == "some updated fournisseur"
      assert commercial.info_projet == "some updated info_projet"
      assert commercial.irrigation == false
      assert commercial.more_detail_echeance == "some updated more_detail_echeance"
      assert commercial.nom == "some updated nom"
      assert commercial.pente == "some updated pente"
      assert commercial.superficie == "some updated superficie"
      assert commercial.tel == "some updated tel"
      assert commercial.type_service == "some updated type_service"
      assert commercial.ville == "some updated ville"
    end

    test "update_commercial/2 with invalid data returns error changeset" do
      commercial = commercial_fixture()
      assert {:error, %Ecto.Changeset{}} = Soumission.update_commercial(commercial, @invalid_attrs)
      assert commercial == Soumission.get_commercial!(commercial.id)
    end

    test "delete_commercial/1 deletes the commercial" do
      commercial = commercial_fixture()
      assert {:ok, %Commercial{}} = Soumission.delete_commercial(commercial)
      assert_raise Ecto.NoResultsError, fn -> Soumission.get_commercial!(commercial.id) end
    end

    test "change_commercial/1 returns a commercial changeset" do
      commercial = commercial_fixture()
      assert %Ecto.Changeset{} = Soumission.change_commercial(commercial)
    end
  end
end
