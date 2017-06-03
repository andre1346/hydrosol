defmodule Hydrosol.Soumission.Commercial do
  use Ecto.Schema
  import Ecto.Changeset
  alias Hydrosol.Soumission.Commercial


  schema "soumission_commercials" do
    field :address, :string
    field :adresse_projet, :string
    field :caracteristique_travaux, :string
    field :codepostal, :string
    field :comment, :string
    field :complementaire, :string
    field :contact, :string
    field :easy_access, :boolean, default: false
    field :echeance, :string
    field :email, :string
    field :etat_terrain, :string
    field :fournisseur, :string
    field :info_projet, :string
    field :irrigation, :boolean, default: false
    field :more_detail_echeance, :string
    field :nom, :string
    field :pente, :string
    field :superficie, :string
    field :tel, :string
    field :type_service, :string
    field :ville, :string

    timestamps()
  end

  @doc false
  def changeset(%Commercial{} = commercial, attrs) do
    commercial
    |> cast(attrs, [:nom, :contact, :address, :ville, :codepostal, :tel, :email, :info_projet, :adresse_projet, :superficie, :caracteristique_travaux, :type_service, :complementaire, :echeance, :more_detail_echeance, :pente, :fournisseur, :etat_terrain, :easy_access, :irrigation, :comment])
    |> validate_required([:nom, :contact, :address, :ville, :codepostal, :tel, :email, :info_projet, :adresse_projet, :superficie, :caracteristique_travaux, :type_service, :complementaire, :echeance, :more_detail_echeance, :pente, :fournisseur, :etat_terrain, :easy_access, :irrigation, :comment])
  end
end
