defmodule Hydrosol.Soumission.Residentiel do
  use Ecto.Schema
  import Ecto.Changeset
  alias Hydrosol.Soumission.Residentiel


  schema "soumission_residentiels" do
    field :address, :string
    field :codepostal, :string
    field :comment, :string
    field :complementaire, :string
    field :easy_access, :boolean, default: false
    field :email, :string
    field :etat_terrain, :string
    field :fournisseur, :string
    field :info_projet, :string
    field :irrigation, :boolean, default: false
    field :nom, :string
    field :pente, :string
    field :prenom, :string
    field :superficie, :string
    field :tel, :string
    field :ville, :string

    timestamps()
  end

  @doc false
  def changeset(%Residentiel{} = residentiel, attrs) do
    residentiel
    |> cast(attrs, [:nom, :prenom, :address, :ville, :codepostal, :tel, :email, :info_projet, :superficie, :complementaire, :pente, :fournisseur, :etat_terrain, :easy_access, :irrigation, :comment])
    |> validate_required([:nom, :prenom, :address, :ville, :codepostal, :tel, :email, :info_projet, :superficie, :complementaire, :pente, :fournisseur, :etat_terrain, :easy_access, :irrigation, :comment])
  end
end
