defmodule Hydrosol.Repo.Migrations.CreateHydrosol.Soumission.Residentiel do
  use Ecto.Migration

  def change do
    create table(:soumission_residentiels) do
      add :nom, :string
      add :prenom, :string
      add :address, :string
      add :ville, :string
      add :codepostal, :string
      add :tel, :string
      add :email, :string
      add :info_projet, :string
      add :superficie, :string
      add :complementaire, :string
      add :pente, :string
      add :fournisseur, :string
      add :etat_terrain, :string
      add :easy_access, :boolean, default: false, null: false
      add :irrigation, :boolean, default: false, null: false
      add :comment, :text

      timestamps()
    end

  end
end
