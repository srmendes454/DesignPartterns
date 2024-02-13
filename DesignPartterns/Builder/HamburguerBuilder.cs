﻿namespace DesignPartterns.Builder
{
    public abstract class HamburguerBuilder
    {
        protected Hamburguer hamburguer;

        public void Criar() => hamburguer = new Hamburguer();
        public Hamburguer Obter() => hamburguer;

        public abstract void ReceberPedido();
        public abstract void PedidoRecebido();
    }
}
