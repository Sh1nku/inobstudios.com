﻿var vueReference = null;
$(document).ready(function () {
    vueReference = new Vue({
        el: '#main-container',
        store: store,
        computed: {
            posts() {
                return this.$store.state.posts;
            },
            limit() {
                return this.$store.state.limit;
            },
            offset() {
                return this.$store.state.offset;
            }
        },
        data: {

        },
        methods: {

        },
        mounted: function () {
            this.$nextTick(function () {
                this.$store.dispatch('init');
                document.querySelectorAll('pre code').forEach((block) => {
                    hljs.highlightBlock(block)
                });
            });
        },
        updated: function () {
            this.$nextTick(function () {
                document.querySelectorAll('pre code').forEach((block) => {
                    if (block.childElementCount == 0) {
                        hljs.highlightBlock(block)
                    }
                });
            });
        }
    });
});