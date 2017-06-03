defmodule Hydrosol.Repo.Migrations.CreateHydrosol.Soumission.Commercial do
  use Ecto.Migration

  def change do
    create table(:soumission_commercials) do
      add :nom, :string
      add :contact, :string
      add :address, :string
      add :ville, :string
      add :codepostal, :string
      add :tel, :string
      add :email, :string
      add :info_projet, :string
      add :adresse_projet, :string
      add :superficie, :string
      add :caracteristique_travaux, :string
      add :type_service, :string
      add :complementaire, :string
      add :echeance, :string
      add :more_detail_echeance, :string
      add :pente, :string
      add :fournisseur, :string
      add :etat_terrain, :string
      add :easy_access, :boolean, default: false, null: false
      add :irrigation, :boolean, default: false, null: false
      add :comment, :string

      timestamps()
    end

  end
end
